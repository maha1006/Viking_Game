using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger : MonoBehaviour
{
    public BattleSystem openBattleSystem;
    public PathFollower pathFollow;
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
