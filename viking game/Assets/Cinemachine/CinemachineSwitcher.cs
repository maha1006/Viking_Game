using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField]

    private CinemachineVirtualCamera vcam1;

    [SerializeField]

    private CinemachineVirtualCamera vcam2;



    private Animator animator;

    private bool OverviewCam = true;

    private void Awake()
    {
        //animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {

    }

    private void SwitchState() 
    { 
        if (OverviewCam)
        {
            animator.Play("Detail");
        }
        else
        {
            animator.Play("Overview");
        }
        OverviewCam = !OverviewCam;
    }

    

    private void SwitchPriority()
    {
        if (OverviewCam)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }

        OverviewCam = !OverviewCam;
    }
    public void SwitchPriority2()
    {
        if (OverviewCam)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }

        OverviewCam = !OverviewCam;
    }

    private void OnTriggerEnter(Collider other)
    {
        SwitchPriority();
    }

    private void OnTriggerExit(Collider other)
    {
        SwitchPriority2();
    }

}
