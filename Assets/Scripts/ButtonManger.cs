using UnityEngine;
using System.Collections;

public class ButtonManger : MonoBehaviour {


	public void RestartLevel()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void LoadMainMenu()
	{

		// Requires to be in the build settings
		Application.LoadLevel ("Menu");
	}

	public void LoadLevel1(){
		Application.LoadLevel ("Level1");
	}


}
