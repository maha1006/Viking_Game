using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger : MonoBehaviour
{
    public BattleSystem openBattleSystem;
    public PathFollower pathFollow;
    public BoatController boatController;
    


    void OnEnable()
    {
        Debug.Log("PrintOnEnable: script was enabled");
    }

    void OnTriggerEnter(Collider other)
    {
        openBattleSystem.gameObject.SetActive(true);
        pathFollow.StopShip();
        boatController.StopPlayer();
        

    }
}
