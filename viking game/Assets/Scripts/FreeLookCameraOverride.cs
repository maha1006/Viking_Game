using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FreeLookCameraOverride : MonoBehaviour
{

    public CinemachineFreeLook freeLookCam;

    CinemachineOrbitalTransposer.AngularDampingMode YAxis;
    void OnTriggerEnter()
    {
        freeLookCam.m_YAxis.Value = 1f;
    }
    void OnTriggerExit()
    {
        freeLookCam.m_YAxis.Value = 0.5f;
    }
}
