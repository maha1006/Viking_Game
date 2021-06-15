using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMarker : MonoBehaviour

{
    public questcompass questcompass;
    public questmarker questmarker;
    public void AddQuestmarker()
    {
     questcompass.AddQuestMarker(questmarker);
    }
}
