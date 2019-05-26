﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleBad : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI pointsScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent " + collision.gameObject.name);

        if (collision.gameObject.name == "bee")
        {
            score -= 20;
            Debug.Log("score " + score);
            pointsScore.text = score.ToString();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");

    }
}

