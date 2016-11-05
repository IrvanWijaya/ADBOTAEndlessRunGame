using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public string playScene;

	public void play(){
		Application.LoadLevel (playScene);
	}

	public void quit(){
		Application.Quit ();
	}
}
