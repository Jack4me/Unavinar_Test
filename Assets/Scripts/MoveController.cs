using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveController : MonoBehaviour

{
    [SerializeField] private float _speedPlayer = 5f;
    [SerializeField] private float _speedRotation = 600;
    [SerializeField] private float _smooth = 5;
    private float _accelerationPlayer;
    private float _timer;
    private float angleY;
    private float _currentAngle;

    private bool _hit = false;
    private int count = 0;
    private Vector3 playerDirection;
    public Score _scoreRef;


    void Start()
    {
        MoveDirection();
        _accelerationPlayer = 2f;
    }

    private void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.Space))
        {
            _scoreRef.IsAcceleration = true;
            Debug.Log("GOOOOO!!!!");
            transform.position -= -playerDirection * Time.deltaTime * _accelerationPlayer;
        }


        if (_hit)
        {
            direction = -playerDirection * Time.deltaTime;
        }
        else
        {
            direction = playerDirection * Time.deltaTime;
        }


        transform.position += direction;

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse1");

            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * _speedRotation);

            Debug.Log(angleY + "angleY");


        }

        else
        {
            Debug.Log("Отпустил Мышку");
            _currentAngle = transform.rotation.eulerAngles.y;
            Quaternion target = Quaternion.Euler(0, Nearest(_currentAngle), 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * _smooth);
        }
    }

    public float Nearest(float currentAngle)
    {
        float nearestAngle = (int)((currentAngle + 45) / 90) * 90;
        return nearestAngle;
    }

    void MoveDirection()
    {
        playerDirection = new Vector3(0, 0, 1 * _speedPlayer);
    }

    public void Hit()
    {
        StartCoroutine("HitCoroutine");
        _scoreRef.IsHitTheBlock = true;
    }

    private IEnumerator HitCoroutine()
    {
        if (count < 2)
        {
            _hit = true;
            yield return new WaitForSeconds(0.5f);
            _hit = false;
            count++;
        }
        else
        {
            yield return new WaitForSeconds(3f);
            count = 0;
        }
    }
}