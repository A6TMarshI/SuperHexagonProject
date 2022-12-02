using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCycling : MonoBehaviour
{

    public Color[] Colors;
    public float Speed = 5;
    int _currentIndex = 0;
    Camera _cam;

    void Start()
    {
        _cam = GetComponent<Camera>();

        _currentIndex = 0;
        SetColor(Colors[_currentIndex]);
    }

    public void SetColor(Color color)
    {
        _cam.backgroundColor = color;
    }


    void Update()
    {
            var startColor = _cam.backgroundColor;

            var endColor = Colors[0];
            if (_currentIndex + 1 < Colors.Length)
            {
                endColor = Colors[_currentIndex + 1];
            }


            _cam.backgroundColor = Color.Lerp(startColor, endColor, Time.deltaTime * Speed);
            

            if (_cam.backgroundColor == endColor)
            {
                if (_currentIndex + 1 < Colors.Length)
                {
                    _currentIndex++;
                }
                else
                {
                    _currentIndex = 0;
                }
            }
    }
}