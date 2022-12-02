using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class TestTernarniyOper : MonoBehaviour
{
    private float _curent;


    public Transform target;

    [Range(0, 1)] public float value;

    void Update()
    {
        Vector3 currentLook = transform.rotation * Vector3.up;
        Debug.Log(currentLook);
       
        
        // transform.rotation = Quaternion.LookRotation(currentLook);
    }
    

    // public Vector3 NearestAngle()
    // {
    //     if (Input.GetMouseButton(0))
    //     {
    //         float pixels = Input.GetAxis("Mouse X");
    //
    //         if (Input.GetAxis("Mouse X") < -0.5f)
    //         {
    //             Vector3 nearestAngle = Vector3.Lerp(transform.eulerAngles, Vector3.forward, Time.deltaTime);
    //             return nearestAngle;
    //             Debug.LogWarning("Аааа - 0.5");
    //         }
    //
    //         Debug.Log(pixels);
    //     }
    //
    //     return Vector3.zero;
    // }

    // private Vector3 SnapTo(Vector3 v3, float snapAngle)
    // {
    //     float angle = Vector3.Angle(v3, Vector3.up);
    //     if (angle < snapAngle / 2.0f) // Cannot do cross product 
    //         return Vector3.up * v3.magnitude; //   with angles 0 & 180
    //     if (angle > 180.0f - snapAngle / 2.0f)
    //         return Vector3.down * v3.magnitude;
    //
    //     float t = Mathf.Round(angle / snapAngle);
    //     float deltaAngle = (t * snapAngle) - angle;
    //
    //     Vector3 axis = Vector3.Cross(Vector3.up, v3);
    //     Quaternion q = Quaternion.AngleAxis(deltaAngle, axis);
    //     return q * v3;
    // }
}