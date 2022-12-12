using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _particleSystem;
    [SerializeField] private Score _score;
    [SerializeField] private MoveController _moveCtrl;

    public bool _IsFinish;
    private GameManager _gameManager;
    public GameObject completeLevelGUI;

    private void Start()
    {
        foreach (var particle in _particleSystem)
        {
            particle.Stop();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _score.HighScore();
            _IsFinish = true;
            foreach (var particle in _particleSystem)
            {
                particle.Play();
            }

            completeLevelGUI.SetActive(true);
            Debug.Log("GAME OVER");
            _moveCtrl.enabled = false;
        }
    }
}