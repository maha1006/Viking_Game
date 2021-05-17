using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
   


    private void Awake ()
    {
       
    }


    public void SceneLoad(string sceneName)
	{
		
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

