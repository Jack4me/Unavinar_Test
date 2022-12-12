using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public float score;
    public float highScoreCounter;
    public Finish finish;


    public bool IsAcceleration;
    public bool IsHitTheBlock;

    private void Awake()
    {
        score = 0;
        HighScore();
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            highScoreCounter = PlayerPrefs.GetInt("SaveScore");
        }
    }

    private void Start()
    {
        highScoreText.text = "Best Score: " + (int)highScoreCounter;
    }

    void Update()
    {
        if (IsAcceleration)
        {
            Debug.Log("Accelerationnn!!!");
            score += 2 * Time.deltaTime;
            if (score > 0)
            {
                scoreText.text = (int)score + "";
            }
            else
            {
                score = 0;
                scoreText.text = (int)score + "";
            }

            IsAcceleration = false;
        }

        else if (IsHitTheBlock)
        {
            Debug.Log("Hit The Block");
            score -= 2 * Time.deltaTime;
            if (score > 0)
            {
                scoreText.text = (int)score + "";
            }
            else
            {
                score = 0;
                scoreText.text = (int)score + "";
            }

            IsHitTheBlock = false;
        }
        else if (finish._IsFinish)
        {
            scoreText.text = (int)score + "";
        }

        else
        {
            Debug.Log("Too-Too");
            score += 1 * Time.deltaTime;
            scoreText.text = (int)score + "";
        }
    }

    public void HighScore()
    {
        if (score > highScoreCounter)
        {
            Debug.Log("Сейв Скор");
            highScoreCounter = score;
            PlayerPrefs.SetInt("SaveScore", (int)highScoreCounter);
        }
    }
}