using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 2;
    [SerializeField] private float _speedPlayer = 800;

    private Rigidbody _playerRb;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * _speedRotation);
        _playerRb.AddForce(new Vector3(0, 0, 1 * _speedPlayer * Time.deltaTime));

        if (transform.position.z > 40)
        {
            _playerRb.drag = 2;
            _speedPlayer = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("slowMove"))
        {
            _playerRb.drag = 5;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("slowMove"))
        {
            _playerRb.drag = 0;
        }
    }
}