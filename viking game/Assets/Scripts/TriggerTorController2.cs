using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTorController2 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string TorOpen = "TorRechtsOpen";
    [SerializeField] private string TorClose = "TorRechtsClose";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("TorRechtsOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play("TorRechtsClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
