using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRessources1 : MonoBehaviour
{
    public void RemoveRessources()
    {
        ScoringSystem.theScore -= 3;
    }

    public void RemoveRessources2()
    {
        ScoringSystem.theScore -= 15;
    }

}
