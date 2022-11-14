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
    [SerializeField] private float _power = 20;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider wallCollider)
    {
        if (wallCollider.CompareTag("WallBrick"))
        {
            Rigidbody wallRigidody = wallCollider.GetComponent<Rigidbody>();
            wallRigidody.useGravity = true;
            wallRigidody.AddForce(0, 0, 1 * _power);
            _moveCtrl.Hit();
            wallCollider.isTrigger = false;
        }

        if (wallCollider.gameObject.CompareTag("End"))
        {
            Debug.Log("GAME OVER");
            _moveCtrl.enabled = false;
        }
    }
}