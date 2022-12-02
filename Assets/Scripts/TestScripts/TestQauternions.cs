using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQauternions : MonoBehaviour
{
    private float _currentAngle;

    public Rigidbody _rb;

    private void Start()
    {
        
    }

    private void Update()
    {
        // Vector3 direction = cube2.transform.position - transform.position;
        // transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        if (Input.GetMouseButton(0))
        {
            _currentAngle = transform.rotation.eulerAngles.y;
            Quaternion target = Quaternion.Euler(0, Nearest(_currentAngle), 0);
        }
    }

    public float Nearest(float currentAngle)
    {
        float nearestAngle = (int)((currentAngle + 45) / 90) * 90;
        return nearestAngle;
    }
}