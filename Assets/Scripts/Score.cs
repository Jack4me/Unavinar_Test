using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public float increasePerSecond;

    public bool IsAcceleration;
    public bool IsHitTheBlock;

    private void Start()
    {
        score = 0;
        increasePerSecond = 1;
    }

    void Update()
    {
        if (IsAcceleration)
        {
            Debug.Log("Accelerationnn!!!");
            score += 2 * Time.deltaTime;
            scoreText.text = (int)score + "";
            IsAcceleration = false;
        }

        else if (IsHitTheBlock)
        {
            Debug.Log("Hit The Block");
            score -= 2 * Time.deltaTime;
            scoreText.text = (int)score + "";
            IsHitTheBlock = false;
        }
        else
        {
            Debug.Log("Too-Too");
            score += 1 * Time.deltaTime;
            scoreText.text = (int)score + "";
        }
    }
}