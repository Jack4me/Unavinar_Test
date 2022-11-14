using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform _player;
    public Text scoreText;
    // private static int _score = 0;

    private void OnGUI()
    {
        
    }

    void Update()
    {
        scoreText.text = _player.position.z.ToString("0");
    }
}
