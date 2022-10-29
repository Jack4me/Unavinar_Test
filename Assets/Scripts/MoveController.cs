using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour

{
    [SerializeField] private float _speedRotation = 600;
    [SerializeField] private float _speedPlayer = 5f;


    private Rigidbody _playerRb;
    private Vector3 playerDirection;

    void Start()
    {
        MoveDirection();
        _playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MouseCtrlPlayer();

        transform.position += playerDirection * Time.deltaTime;

        if (transform.position.z > 40)
        {
            transform.position = new Vector3(0, 0f, 40);
            _speedPlayer = 0;
        }
    }

    void MouseCtrlPlayer()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * _speedRotation);
    }

    void MoveDirection()
    {
        playerDirection = new Vector3(0, 0, 1 * _speedPlayer);
    }

    public void Hit()
    {
        
    }
}