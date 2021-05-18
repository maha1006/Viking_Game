using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemIron : MonoBehaviour
{
    public AudioSource collectSound;
    public Quest quest;
    public Player goBattle;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystemIron.theScore += 1;
        goBattle.GoBattle();
        Destroy(gameObject);
    }


}

