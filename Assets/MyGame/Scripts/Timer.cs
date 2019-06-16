﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;

    public TextMeshProUGUI timeText;
    public float maxTime = 60f;
    public string deathScene = "End";
    private ScoreManager scoreManager;
    private string scoreManagerName = "ScoreManager";

    // Use this for initialization
    void Start()
    {
        time = maxTime;
        scoreManager = GameObject.Find(scoreManagerName).GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = time.ToString("F");

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time <= 0)
        {
            scoreManager.SaveScore();
            SceneManager.LoadScene(deathScene);
        }

    }
}
