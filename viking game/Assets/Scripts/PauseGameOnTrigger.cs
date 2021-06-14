using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameOnTrigger : MonoBehaviour
{
    public GameObject infoWindow;
    public static bool GameIsPaused = false;

    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        Pause();
        OpenInfoWindow();
    }
    public void OpenInfoWindow()
    {
        infoWindow.SetActive(true);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        infoWindow.SetActive(false);
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }  
     
}
