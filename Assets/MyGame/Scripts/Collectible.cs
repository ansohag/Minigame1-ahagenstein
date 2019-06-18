using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    //Triggerevent
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent " + collision.gameObject.name);
        //Wenn Items mit GameObject "bee" kollidieren wird 10 dazu gezählt
        if (collision.gameObject.name == "bee")
        {
            ScoreManager.localScore += 10;
            Debug.Log(ScoreManager.localScore);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");

    }



}
