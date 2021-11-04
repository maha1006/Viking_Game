using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_3 : MonoBehaviour
{
    public BattleSystem3 openBattleSystem;
    public BoatController boatController;
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
            boatController.StopPlayer();
            impact.SetActive(true);
        }
    }


    public void toggleOffImpact()
    {
        impact.SetActive(false);
    }
}
