using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour

{
    [SerializeField] private float _speedRotation = 600;
     public float _speedPlayer = 5f;


    private Vector3 playerDirection;
    private bool _hit = false;

    void Start()
    {
        MoveDirection();
    }

    private void Update()
    {
        MouseCtrlPlayer();

        Vector3 direction = Vector3.zero;
        if (_hit)
        {
            direction = -playerDirection * Time.deltaTime;
        }
        else
        {
            direction = playerDirection * Time.deltaTime;
        }

        transform.position += direction;
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
        StartCoroutine("HitCoroutine");
    }

    private IEnumerator HitCoroutine()
    {
        _hit = true;
        yield return new WaitForSeconds(0.5f);
        _hit = false;
    }
}