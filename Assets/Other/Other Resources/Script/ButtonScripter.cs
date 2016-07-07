using UnityEngine;
using System.Collections;

public class ButtonScripter : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void goToPlayScene() {
		Application.LoadLevel("play");
	}

	public void exitGame() {
		Application.Quit ();
	}

	public void returnToMainMenu() {
		Application.LoadLevel ("mainMenu");
		Time.timeScale = 1;
	}

}
