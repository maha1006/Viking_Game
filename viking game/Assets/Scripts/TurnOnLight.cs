using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLight : MonoBehaviour
{
    float minLuminosity = 0; 
    float maxLuminosity = 4;

    public Light myLight;
    public GameObject GodsBlessing;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
       if(GodsBlessing.activeSelf)
        {
            if(myLight.intensity < maxLuminosity)
            {
                myLight.intensity += Time.deltaTime;
            }

            else
            {
                myLight.intensity = maxLuminosity;

            }
        }
    }
}
