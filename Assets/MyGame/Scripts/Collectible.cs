using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    //private int score = 0;
    //public TextMeshProUGUI pointsScore;
    //public MyScore myScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent " + collision.gameObject.name);

        if (collision.gameObject.name == "bee")
        {
            ScoreManager.localScore += 10;
            Debug.Log(ScoreManager.localScore);
            //Debug.Log("score bee " + myScore);
            //PointsScore.text = score.ToString();
            //pointsScore.text = score.score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");

    }



}
