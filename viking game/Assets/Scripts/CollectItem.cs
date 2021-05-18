using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public AudioSource collectSound;
    //public QuestGoal qg;
    public Quest quest;
    
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        //quest.goal.ItemCollected();
        //qg.ItemCollected();
        //Amount();
        Destroy(gameObject);
        
    }

   /* public void Amount()
    {
        if (quest.isActive)
        {
            quest.goal.ItemCollected();
            if (quest.goal.IsReached())
            {
                quest.Complete();
            }
        }
    }*/
}

