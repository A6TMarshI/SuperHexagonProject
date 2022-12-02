using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float speed = 30;
    public float tSpeed = 5;
    public float longitude = 225;
    float unexpectedEventTimer;
    public int EventID = 0;
    void Start()
    {
        unexpectedEventTimer = Random.Range(1500, 2000);
    }

    // Update is called once per frame
    void Update()
    {
        if (unexpectedEventTimer > 0)
            unexpectedEventTimer--;
        else
        {
            EventID = Random.Range(0,2);
            unexpectedEventTimer = Random.Range(1500, 2000);
        }
        if(!PauseMenu.isPaused)
        switch(EventID)
        {
            case 0:
                Rotation(speed, tSpeed, longitude);
                break;
            case 1:
                Rotation(-speed, tSpeed, longitude);
                break;
        }
        
    }
    void Rotation(float _speed, float _tSpeed, float longitude)
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * _speed);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (Mathf.Sin(Time.time * _tSpeed) / longitude));
    }
}
