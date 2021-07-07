using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScreen : MonoBehaviour
{
   
    public GameObject finalWindow;
    public static bool GameIsPaused = false;

    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            finalWindow.SetActive(true);
            Pause();
        }
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
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
