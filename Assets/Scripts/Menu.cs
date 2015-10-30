using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene(string sceneName)
    {
        Screen.SetResolution(1280, 800, true);
        Application.LoadLevel(sceneName);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
