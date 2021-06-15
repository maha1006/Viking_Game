using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameOnTrigger : MonoBehaviour
{
    public GameObject infoWindow;
    public static bool GameIsPaused = false;
    public Quest quest;
    public Player player;

    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        Pause();
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
