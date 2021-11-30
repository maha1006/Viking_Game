using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCutscene : MonoBehaviour
{
    public GameObject cutsceneCam;

    public void PlayCutscenes()
    {
        cutsceneCam.SetActive(true);
        StartCoroutine(FinishCut());

    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(17);
        cutsceneCam.SetActive(false);
    }
}
