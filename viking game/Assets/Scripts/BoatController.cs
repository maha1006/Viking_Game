using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    private float moveInput;
    private float turnInput;

    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;

    public TimerScript timerScript;

    public Rigidbody sphereRB;
    public UpgradeBoatBrecher upgradeBoatBrecher;



    void Start()
    {
        sphereRB.transform.parent = null;

    }

    public void StopPlayer()
    {
        fwdSpeed = 0;
        revSpeed = 0;
        turnSpeed = 0;
        Debug.Log("stop player");
    }
    public void StartPlayer()
    {
        if (upgradeBoatBrecher.UpgradeSegel == true)
        {
            fwdSpeed = 65;
            revSpeed = 40;
            turnSpeed = 80;
            Debug.Log("reset upgrade speed");
        }
        else
        {
            fwdSpeed = 50;
            revSpeed = 30;
            turnSpeed = 60;
            Debug.Log("reset default speed");
        }
        

       
    }
    void Update()
    {

        moveInput = Input.GetAxisRaw("Vertical");
        turnInput = Input.GetAxisRaw("Horizontal");

        moveInput *= moveInput > 0 ? fwdSpeed : revSpeed;


        transform.position = sphereRB.transform.position;

        float newRotation = turnInput * turnSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.Rotate(0, newRotation, 0, Space.World);

        

        if (Input.GetButton("Fire3"))
        {
            if (timerScript.timerBar.fillAmount > 0.9f)
            {
                if (timerScript.timerBar.fillAmount < 1f)
                {
                    fwdSpeed = 200;
                    print("now");
                }
            }
        }
        else
        {
            if (upgradeBoatBrecher.UpgradeSegel == true)
            {
                fwdSpeed = 65;
                revSpeed = 40;
                turnSpeed = 80;
                //Debug.Log("reset upgrade speed");
            }
            else
            {
                fwdSpeed = 50;
                revSpeed = 30;
                turnSpeed = 60;
                //Debug.Log("reset default speed");
            }
        }

        if (timerScript.timerBar.fillAmount < 0.05f)
        {
            if (upgradeBoatBrecher.UpgradeSegel == true)
            {
                fwdSpeed = 65;
                revSpeed = 40;
                turnSpeed = 80;
                //Debug.Log("reset upgrade speed");
            }
            else
            {
                fwdSpeed = 50;
                revSpeed = 30;
                turnSpeed = 60;
                //Debug.Log("reset default speed");
            }
        }
    }

    private void FixedUpdate()
    {
        sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
    }
}
