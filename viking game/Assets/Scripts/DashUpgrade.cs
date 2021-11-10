using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashUpgrade : MonoBehaviour
{

    public GameObject DashBalken;
    public GameObject ReachedWindow;

    void Start()
    {
        DashBalken.SetActive(false);
    }

    public void dashUpgrade()
    {
        DashBalken.SetActive(true);
        
    }

    public void CloseReachedWindow()
    {
        ReachedWindow.SetActive(false);
    }
}
