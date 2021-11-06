using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 5f;
    float minTime = 1f;
    public float timeLeft;
    //public GameObject timesUpText;
    
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    

    void Update()
    {
        
         if (Input.GetButton("Fire3"))
         {
                if (timeLeft > 0)
                {
                    timeLeft -= Time.deltaTime;
                    timerBar.fillAmount = timeLeft / maxTime;
                    //print("space key was pressed");
                }
         }
        

        else
        {
            if (timeLeft < maxTime)
            {
                timeLeft += Time.deltaTime / 5;
                timerBar.fillAmount = timeLeft / maxTime;
            }
        }
        
    }
}
