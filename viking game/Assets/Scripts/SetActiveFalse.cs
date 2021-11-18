using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveFalse : MonoBehaviour
{
    public GameObject disable;

    public void Deactivate()
    {
        disable.SetActive(false);
    }
}
