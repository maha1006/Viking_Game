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
    float lastValue;
    //public GameObject timesUpText;

    public bool decreasing;
    public bool increasing;

    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        lastValue = timerBar.fillAmount;
    }

    

    void Update()
    {
        if (timerBar.fillAmount < lastValue)
        {
            //Debug.Log("decreased");
            decreasing = true;
            increasing = false;
           lastValue = timerBar.fillAmount;
        }

        else if (timerBar.fillAmount > lastValue)
        {
            //Debug.Log("increased");
            decreasing = false;
            increasing = true;
           lastValue = timerBar.fillAmount;
            
        }

        if (timerBar.fillAmount > 0.9f)
        {
            decreasing = true;
            increasing = false;
        }

        if (timerBar.fillAmount < 0.05f)
        {
            decreasing = false;
            increasing =true;
        }

        if (decreasing)
        {
            //Debug.Log("chillig");

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
        
        if (increasing)
        {
            timeLeft += Time.deltaTime / 5;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        
    }
}
