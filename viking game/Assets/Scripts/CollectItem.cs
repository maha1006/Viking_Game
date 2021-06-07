using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public AudioSource collectSound;
    public Quest quest;
    public Player goBattle;
    
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        goBattle.GoBattle();
        Destroy(gameObject);
        
    }

    public void CollectItemScore()
    {
        ScoringSystem.theScore += 1;
    }
}

