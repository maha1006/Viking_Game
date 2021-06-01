using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomOut : MonoBehaviour {

    public bool ZoomActive;

    public Vector3[] Target;

    public Camera Cam;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;        
    }

    //Update is called once per frame
    void LateUpdate()
    {
      if(ZoomActive)
      {
        Cam.fieldOfView = Mathf.Lerp(Cam.fieldOfView, 20, Speed);
      }
      else
      {
        Cam.fieldOfView = Mathf.Lerp(Cam.fieldOfView, 12, Speed);
      }
    }

    private void OnTriggerEnter(Collider other)
    {
        ZoomActive = true;
    }
    private void OnTriggerExit(Collider other)
    {
        ZoomActive = false;
    }
}
