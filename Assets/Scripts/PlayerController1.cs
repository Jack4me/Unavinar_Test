using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController1 : MonoBehaviour
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

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("slowMove"))
        {
            Debug.Log("Я Внутри");
            _playerRb.drag = 5;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("slowMove"))
        {
            Debug.Log("Я Внутри");
            _playerRb.drag = 0;
            
        }
    }
    
    
}