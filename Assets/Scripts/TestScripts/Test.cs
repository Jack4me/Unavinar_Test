using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float curentPosition;

    public float minAngle = 0;
    public float maxAngle = 90f;
    public float _speedRotation = 10;

    private void Start()
    {
    }

    private void Update()
    {
        // curentPosition = transform.rotation.eulerAngles.y;
        // Debug.Log(curentPosition);
        if (Input.GetMouseButton(0))
        {
            float angleY = transform.rotation.eulerAngles.y;

            Debug.Log(angleY);


            // transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * _speedRotation);
            // float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
            // transform.eulerAngles = new Vector3(0, angle, 0);
        }
    }
}