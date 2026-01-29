using System;
using UnityEngine;

public class AnalogClockController : MonoBehaviour
{
    [SerializeField] private Transform hours, minutes, seconds;
    private Quaternion initialHours, initialMinutes, initialSeconds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialHours = hours.localRotation;
        initialMinutes = minutes.localRotation;
        initialSeconds = seconds.localRotation;

        float hourAngle = (DateTime.Now.Hour % 12) * 30f;
        float minutesAngle = DateTime.Now.Minute * 6f;
        float secondsAngle = DateTime.Now.Second * 6f;

        
        hours.rotation = Quaternion.Euler(hourAngle, 0f, -90f);   
        minutes.rotation = Quaternion.Euler(minutesAngle, 0f, -90f);
        seconds.rotation = Quaternion.Euler(secondsAngle, 0f, -90f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
