using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWeather : MonoBehaviour
{
    public ParticleSystem Weather;
    //public ParticleSystem Weather2;
    public GameObject WeatherSystem;
    //public GameObject WeatherSystem2;


    void Start()
    {
        Weather.Play(false);
        //Weather2.Play(false);
        WeatherSystem.SetActive(false);
        //WeatherSystem2.SetActive(false);
    }

    public void StartWeatherSystem()
    {
        Weather.Play(true);
        //Weather2.Play(true);
        WeatherSystem.SetActive(true);
        //WeatherSystem2.SetActive(true);
    }
}
