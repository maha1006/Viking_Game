using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal 
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;
    public int currentAmountKill;
    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void EnemyKilled()
    {
        if (goalType == GoalType.Kill)
        currentAmountKill++;
    }

    public void ItemCollected()
    {
        currentAmount = ScoringSystem.theScore;
    }
}

   

public enum GoalType
{
    Kill,
    Gathering
}