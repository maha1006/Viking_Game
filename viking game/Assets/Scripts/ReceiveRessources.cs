using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveRessources : MonoBehaviour
{
    public int RessourceAmount;

    public void getRessources()
    {
        ScoringSystem.theScore += RessourceAmount;
    }
}
