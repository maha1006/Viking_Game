using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlame : MonoBehaviour
{

    public Player goBattle;
    public GameObject FlameWindow;
    public GameObject WaleFlame;
    public GameObject KrakenFlame;
    public GameObject LeviathanFlame;

    public GameObject WindowNext0Flames;
    public GameObject WindowNext1Flame;
    public GameObject WindowNext1FlameExtra;
    public GameObject WindowNext2Flames;
    
    public bool WaleflameActive;
    public bool KrakenflameActive;
    public bool LeviathanflameActive;

    void Start()
    {
        LeviathanflameActive = false;
        KrakenflameActive = false;
        WaleflameActive = false;
        WaleFlame.SetActive(false);
        KrakenFlame.SetActive(false);
        LeviathanFlame.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlameWindow.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FlameWindow.SetActive(false);
            CloseFlameWindow();
            print("lul");
            
        }
    }

    public void ActivateWaleFlame()
    {
        WaleFlame.SetActive(true);
        WaleflameActive = true;

    } 
    
    public void ActivateKrakenFlame()
    {
        KrakenFlame.SetActive(true);
        KrakenflameActive = true;

    } 
    
    public void ActivateLeviathanFlame()
    {
        LeviathanFlame.SetActive(true);
        LeviathanflameActive = true;

    } 
    
    public void CloseFlameWindow()
    {
        FlameWindow.SetActive(false);
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        
    }

    public void CloseNextWindows()
    {
        WindowNext0Flames.SetActive(false);
        WindowNext1Flame.SetActive(false);
        WindowNext1FlameExtra.SetActive(false);
        WindowNext2Flames.SetActive(false);
    }

    public void FlameActivated()
    {
        goBattle.GoBattle();
    }
 
    public void OpenWindowNext0Flames()
    {
        WindowNext0Flames.SetActive(true);
    }
    
    public void OpenWindowNext1Flame()
    {
        WindowNext1Flame.SetActive(true);
    }
    
    public void OpenWindowNext1FlameExtra()
    {
        WindowNext1FlameExtra.SetActive(true);
    }
    
    public void OpenWindowNext2Flames()
    {
        WindowNext2Flames.SetActive(true);
    }

   
    public void FlameWindowNext()
    {
        if (KrakenflameActive)
        {
            if (WaleflameActive)
            {
                OpenWindowNext2Flames();
                print("2");
            }
            else if (KrakenflameActive)
            {
                OpenWindowNext1FlameExtra();
                print("1");
            }
        }

        else
        {
            OpenWindowNext0Flames();
            print("0");
        }
        
        if (WaleflameActive)
        {
            if (KrakenflameActive)
            {
                OpenWindowNext2Flames();
                print("2");
            }
            else if (WaleflameActive)
            {
                OpenWindowNext1Flame();
                print("1");
            }
        }

        else
        {
            OpenWindowNext0Flames();
            print("0");
        }
    }


}
