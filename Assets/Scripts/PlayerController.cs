using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private MoveController _moveCtrl;
    public Score score;
    private float _power;

    private void Start()
    {
        _power = 10;
    }

    private void OnTriggerEnter(Collider wallCollider)
    {
        if (wallCollider.CompareTag("WallBrick"))
        {
            Rigidbody wallRigibody = wallCollider.GetComponent<Rigidbody>();
            wallCollider.isTrigger = false;
            wallRigibody.useGravity = true;
            wallRigibody.AddForce(0, 0, 1 * _power);
            _moveCtrl.Hit();
            score.score -= 5;
        }
    }
}