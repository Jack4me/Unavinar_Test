using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    [SerializeField] private MoveController _moveCtrl;
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _moveCtrl.Hit();
        Destroy(other.gameObject);
    }
}