using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindeKnut : MonoBehaviour
{

    public GameObject infoWindow;
    public questcompass questcompass;
    public questmarker questmarker;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        infoWindow.SetActive(true);
    }

    public void CloseInfoWindow()
    {
        infoWindow.SetActive(false);
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }

    public void AddMarker()
    {
        questcompass.AddQuestMarker(questmarker);
    }
    public void DeleteMarker()
    {
        questcompass.DeleteQuestMarker(questmarker);
    }

    private void OnTriggerExit(Collider other)
    {
        CloseInfoWindow();
    }

}