using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalZone : MonoBehaviour
{
    public GameObject racket;
    public Text scoretext;
    int score;

    private void Awake()
    {
        score = 0;
        scoretext.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Ball")
        {
            Debug.Log("gol");
            score++;
            scoretext.text = score.ToString();
        }
    }


}
