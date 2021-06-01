using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktivateWaterEmitter : MonoBehaviour
{
    public ParticleSystem FX_BoatWater_Large;

    public float speedAccelerationPerSecond = 0.2f;
    public float speedDeaccelerationPerSecond = 0.2f;
    public float maxSpeed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
                FX_BoatWater_Large.Play();
            if (FX_BoatWater_Large.startSize < maxSpeed)
            {
                FX_BoatWater_Large.startSize += speedAccelerationPerSecond * Time.deltaTime;
            }


            else
            {
                FX_BoatWater_Large.startSize = maxSpeed;
            }

        }

        else 
        {
                FX_BoatWater_Large.Stop();
            //FX_BoatWater_Large.startSize = 0f;
            if (FX_BoatWater_Large.startSize > 0)
            {
                FX_BoatWater_Large.startSize -= speedDeaccelerationPerSecond * Time.deltaTime; //possibly speedDeaccelerationPerSecond depending on your needs
            }
            else
            {
                FX_BoatWater_Large.startSize = 0;
            }

        }
    }


   
}
