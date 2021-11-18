using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closewindow : MonoBehaviour
{
    public GameObject Window;

    public void CloseWindow()
    {
        Window.SetActive(false);
    }
}
