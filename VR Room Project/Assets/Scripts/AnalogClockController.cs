using System;
using UnityEngine;

public class AnalogClockController : MonoBehaviour
{
    [SerializeField] private Transform hours, minutes, seconds;
    private Quaternion initialHours, initialMinutes, initialSeconds;

    float hourAngle = (DateTime.Now.Hour % 12) * 30f + DateTime.Now.Minute * 0.5f;
    float minutesAngle = DateTime.Now.Minute * 6f;
    float secondsAngle = DateTime.Now.Second * 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateClock();
    }

    // Update is called once per frame
    void Update()
    {

        UpdateClock();

    }

    void UpdateClock() {

        hourAngle = (DateTime.Now.Hour % 12) * 30f + DateTime.Now.Minute * 0.5f;
        minutesAngle = DateTime.Now.Minute * 6f;
        secondsAngle = DateTime.Now.Second * 6f;

        hours.rotation = Quaternion.Euler(hourAngle + 90f, 0f, -90f);
        minutes.rotation = Quaternion.Euler(minutesAngle + 90f, 0f, -90f);
        seconds.rotation = Quaternion.Euler(secondsAngle + 90f, 0f, -90f);

    }

}
