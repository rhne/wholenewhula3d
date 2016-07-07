using UnityEngine;
using System.Collections;

public class PauseGameScript : MonoBehaviour {

	public GameManager gameManager;
	public Canvas pauseCanvas = null;

	public void showPauseMenu() {
		if (!pauseCanvas) {
			pauseCanvas.enabled = true;
			//canvas.enabled = true;
			Time.timeScale = 0;
		}
	}

	public void resumeGame() {
		pauseCanvas.enabled = false;
		Time.timeScale = 1;
	}
}