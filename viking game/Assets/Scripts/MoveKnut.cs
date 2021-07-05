using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnut : MonoBehaviour
{
    public Transform Knut;
    public Transform KnutLocation;
    
    public void MoveAway()
    {
        Knut.position = KnutLocation.position;
        
        Debug.Log("move2");
    }
    public void MoveAwayKnut()
    {
        Invoke("MoveAway", 12);
        Debug.Log("move");
    }
    void Update()
    {
        
    }
}
