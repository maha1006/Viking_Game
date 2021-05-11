using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystemIron : MonoBehaviour
{
    public GameObject Iron_Score;
    public static int theScore;


    void Update()
    {
        Iron_Score.GetComponent<Text>().text = "Iron: " + theScore;
    }

}
