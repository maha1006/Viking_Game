using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWeather : MonoBehaviour
{
    public ParticleSystem Weather;
    public GameObject WeatherSystem;
    
    void Start()
    {
        Weather.Play(false);
        WeatherSystem.SetActive(false);
    }

    public void StartWeatherSystem()
    {
        Weather.Play(true);
        WeatherSystem.SetActive(true);
    }
}
