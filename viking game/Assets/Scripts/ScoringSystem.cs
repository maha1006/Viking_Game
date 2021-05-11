using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject Wood_Score;
    public static int theScore;


    void Update()
    {
        Wood_Score.GetComponent<Text>().text = "Wood: " + theScore;
    }

}
