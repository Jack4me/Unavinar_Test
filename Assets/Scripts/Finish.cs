using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private GameManager _gameManager;
    
    private void OnTriggerEnter(Collider other)
    {
        _gameManager.End();
    }
}