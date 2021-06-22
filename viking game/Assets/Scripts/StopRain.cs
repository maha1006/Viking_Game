using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRain : MonoBehaviour
{
    //public GameObject Rain;
    //public GameObject RainDrop;

    public ParticleSystem rain;
    public ParticleSystem rainDrop;
    float fadeOutTime = 4.0f;
    
    void Start()
    {
        //Rain.SetActive(true);
        //RainDrop.SetActive(true);
        rain.Play();
        rainDrop.Play();
    }

    public IEnumerator FadeOut()
    {
        //Rain.SetActive(false);
        //RainDrop.SetActive(false);
        rain.Stop();
        rainDrop.Stop();
        yield return new WaitForSeconds(fadeOutTime);
        Destroy(this.gameObject);
    }
  
}
