using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 25f;
    private bool seMovioLaBola = false;
    void Start()
    {

    }
    private void Update()
    {
        if (GameManager.sharedInstance.startedGame == true && seMovioLaBola == false)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            seMovioLaBola = true;
        }
            if (GameManager.sharedInstance.startedGame) {
                string racketName = (GetComponent<Rigidbody2D>().velocity.x > 0 ? "RacketLeft" : "RacketRight");
                GameObject racket = GameObject.Find(racketName);
                GetComponent<SpriteRenderer>().color = racket.GetComponent<SpriteRenderer>().color;

            }
        }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position, collision.transform.position,
                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        if (collision.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position, collision.transform.position,
                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }

    }
    // metodo que devuelve el factor antes citado
    float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
    {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }


}
