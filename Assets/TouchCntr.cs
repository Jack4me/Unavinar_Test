using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class TouchCntr : MonoBehaviour
{
    [SerializeField] private float _speed = 2;
 
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), 0, 0) * Time.deltaTime * _speed);
        // if (Input.touchCount > 0)
        // {
        //     _rigidbody.AddTorque(Vector3.up * Time.deltaTime * _speed);
        // }
    }

    
}