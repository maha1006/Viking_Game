using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class TriggerTorController : MonoBehaviour
{

    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string TorOpen = "TorLinksOpen";
    [SerializeField] private string TorClose = "TorLinksClose";

    public PathFollower pathFollow;

    public void OpenTor()
    {
        gameObject.SetActive(true);    
    }
    private void OnTriggerEnter(Collider other)
    {
        pathFollow.StartShipfast();
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("TorLinksOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play("TorLinksClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}
