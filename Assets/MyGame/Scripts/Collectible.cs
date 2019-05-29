using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    //private int score = 0;
    public TextMeshProUGUI text;
    public MyScore score;

    private void Update()
    {
        Debug.Log("Update collectible " + score.score.ToString());
        text.text = score.score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent " + collision.gameObject.name);

        if (collision.gameObject.name == "bee")
        {
            score.score += 10;
            Debug.Log("score bee " + score);
            //PointsScore.text = score.ToString();


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");

    }



}
