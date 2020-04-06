using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovement : MonoBehaviour
{
    public float speed = 27.5f;
    public string axis = "Vertical";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (GameManager.sharedInstance.startedGame == true) { 
        float v = Input.GetAxisRaw(axis);
        Debug.Log(v);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed*v);
        }
    }
}
