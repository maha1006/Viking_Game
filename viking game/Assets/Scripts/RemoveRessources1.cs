using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRessources1 : MonoBehaviour
{
    public int RemoveAmount;

    public void RemoveRessourceAmount()
    {
        ScoringSystem.theScore -= RemoveAmount;
    }


    public void RemoveRessources()
    {
        ScoringSystem.theScore -= 3;
    }

    public void RemoveRessources2()
    {
        ScoringSystem.theScore -= 25;
    }

    public void RemoveRessources3()
    {
        ScoringSystem.theScore -= 10;
    }
}
