using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closewindow : MonoBehaviour
{
    public GameObject Window;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Window.SetActive(true);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Window.SetActive(false);
        }
    }

    public void CloseWindow()
    {
        Window.SetActive(false);
    }
}
