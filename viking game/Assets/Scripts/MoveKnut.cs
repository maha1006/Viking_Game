using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnut : MonoBehaviour
{
    public Transform Knut;
    
    public void MoveAway()
    {
       Knut.position = new Vector3(113, -1429, 336);
        
        Debug.Log("move2");
    }
    public void MoveAwayKnut()
    {
        Invoke("MoveAway", 2);
        Debug.Log("move");
    }
    void Update()
    {
        
    }
}
