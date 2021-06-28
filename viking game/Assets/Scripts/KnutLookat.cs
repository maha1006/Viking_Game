using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnutLookat : MonoBehaviour
{

    public GameObject Player;
    
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.LookAt(Player.transform);
    }
}
