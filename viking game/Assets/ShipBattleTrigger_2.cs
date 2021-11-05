using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_2 : MonoBehaviour
{
    public BattleSystem2 openBattleSystem;
    public BoatController boatController;
    public GameObject impact;



    public void start()
    {
        impact.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openBattleSystem.gameObject.SetActive(true);
            boatController.StopPlayer();
            impact.SetActive(true);
        }
    }


    public void toggleOffImpact()
    {
        impact.SetActive(false);
    }
}