using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_4 : MonoBehaviour
{
    public BattleSystem4 openBattleSystem;
    public BoatController boatController;
    public PathFollower pathFollow;
    public GameObject impact;

    public void start()
    {
        impact.SetActive(false);
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openBattleSystem.gameObject.SetActive(true);
            pathFollow.StopShip();
            boatController.StopPlayer();
            impact.SetActive(true);
        }
    }


    public void toggleOffImpact()
    {
        impact.SetActive(false);
    }
}

