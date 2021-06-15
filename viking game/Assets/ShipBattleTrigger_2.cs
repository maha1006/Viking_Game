using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger_2 : MonoBehaviour
{
    public BattleSystem openBattleSystem;
    public BoatController boatController;


    public void Destroy()
    {
        Destroy(this.gameObject);
    }


    void OnTriggerEnter(Collider other)
    {
        openBattleSystem.gameObject.SetActive(true);
        boatController.StopPlayer();
    }
}
