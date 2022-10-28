using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public int speed;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.AddForce(new Vector3(0,0,1 * speed * Time.deltaTime));

        if (transform.position.z > 40)
        {
            playerRb.drag = 2;
            speed = 0;
        }
    }
}
