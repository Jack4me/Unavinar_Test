using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform _player;
    public Text _score;

    
    void Update()
    {
        _score.text = _player.position.z.ToString("0");
    }
}
