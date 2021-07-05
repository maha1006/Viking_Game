using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IslandBanner : MonoBehaviour
{

    public GameObject banner;
    public GameObject nameText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            banner.SetActive(true);
            nameText.SetActive(true);
        }
           
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            banner.SetActive(false);
            nameText.SetActive(false);
        }
    }
}
