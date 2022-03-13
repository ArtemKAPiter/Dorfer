using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    private float _timer;
    private float _wheelSpeed;

    void Start()
    {
        rotationSpeed = 120f;
        _timer = 10f;
        _wheelSpeed =  PlayerPrefs.GetFloat("WheelSpeed");
        if (_wheelSpeed == 0)
            _wheelSpeed = 1f;
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 5 )
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime* _wheelSpeed, 0);
        }

        if (_timer >= 5 && _timer <= 7)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime * _wheelSpeed - Time.deltaTime*30, 0);
        }
        if (_timer >= 7 && _timer <= 10)
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime * _wheelSpeed, 0);
        }
        if (_timer >= 10 && _timer <= 10)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime * _wheelSpeed, 0);

        }
    }
}
