using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_toggle : MonoBehaviour
{
    private Canvas CanvasObject;

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
        }
    }
}
