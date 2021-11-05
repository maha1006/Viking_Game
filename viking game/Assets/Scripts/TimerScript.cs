using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    //public GameObject timesUpText;
    
    void Start()
    {
        timeLeft = -1; 
       // timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        //timeLeft = maxTime;

    }

    

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            timeLeft = maxTime;
            print("space key was pressed");
        }

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
           // timesUpText.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}
