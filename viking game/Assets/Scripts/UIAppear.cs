using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{

    [SerializeField] private Image questwindow;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            questwindow.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            questwindow.enabled = false;
        }
    }
}
