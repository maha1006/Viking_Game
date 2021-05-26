using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class ShipBattleTrigger : MonoBehaviour
{
    public BattleSystem openBattleSystem;
    public PathFollower pathFollow;
    public GameObject enemyBoat;
    
    void OnTriggerEnter(Collider other)
    {
        openBattleSystem.gameObject.SetActive(true);
        
    }
}
