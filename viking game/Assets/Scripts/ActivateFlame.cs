using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlame : MonoBehaviour
{

    public Player goBattle;
    public GameObject FlameWindow;
    public GameObject WaleFlame;

    void Start()
    {
        WaleFlame.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlameWindow.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlameWindow.SetActive(false);
        }
    }

    public void ActivateWaleFlame()
    {
        WaleFlame.SetActive(true);
    } 
    
    public void CloseFlameWindow()
    {
        FlameWindow.SetActive(false);
        Destroy(this);
    }


    public void FlameActivated()
    {
        goBattle.GoBattle();
    }
    
}
