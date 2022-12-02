using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _particleSystem;
    private GameManager _gameManager;
    [SerializeField] public MoveController _moveCtrl;
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