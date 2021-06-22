using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRain : MonoBehaviour
{
    public StartWeather startWeather;

    private void OnTriggerEnter(Collider other)
    {
        startWeather.StartWeatherSystem();
    }
}
