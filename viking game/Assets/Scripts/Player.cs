using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int experience = 40;
    public int gold = 1000;
    public int currentAmount;
    public Quest quest;
    

    public void GoBattle ()
    {
       
        if (quest.isActive)
        {
            quest.goal.EnemyKilled();
            if (quest.goal.IsReached())
            {
                quest.Complete();
            }
        }
    }

    public void GoItem()
    {
        if (quest.isActive)
        {
            quest.goal.ItemCollected();
            if (quest.goal.IsReached())
            {
                quest.Complete();
            }
        }
    }

}
