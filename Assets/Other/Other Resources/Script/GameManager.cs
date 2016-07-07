using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//GameManager
//storing scores and controlling behaviors

public class GameManager : MonoBehaviour {
	public int maxMissAllowed = 3;
	public Text scoreText;
	public GreenRingBehavior greenRing;
	public Canvas gameOverCanvas;
	public float speed = 50f;

	private int calorie;
	private int missCount;
	private int highestCombo;
	private int currentCombo;
	private int totalHit;
	private int totalMiss;
	private bool gameOver;

	float milestone;
	float multiplier;


	// Use this for initialization
	void Start () {
		calorie = 0;
		missCount = 0;
		highestCombo = 0;
		currentCombo = 0;
		totalHit = 0;
		totalMiss = 0;
		gameOver = false;

		milestone = 4f;
		multiplier = 3f;


		gameOverCanvas.enabled = false;
		//gameOverCanvas = GameObject.Find ("GameOverCanvas");
		UpdateScoreText ();
	}

	//called by slider arrow when hit
	public void AddScoreHit() {
		calorie += 100;
		totalHit += 1;
		missCount = 0;
		currentCombo += 1;
		UpdateScoreText ();
	}

	//called by slider arrow when hit but missed
	public void AddScoreHitnMiss() {
		calorie += 10;
		UpdateScoreText ();

		totalMiss += 1;
		missCount += 1;
		if (missCount == maxMissAllowed) {
			GameOver ();
		}

		//deprecate combo count
		UpdateHighestCombo(currentCombo);
		currentCombo = 0;
	}

	//called by slider arrow when completely missed
	public void MissTheGreen() {
		UpdateScoreText ();

		totalMiss += 1;
		missCount += 1;
		if (missCount == maxMissAllowed) {
			GameOver ();
		}

		UpdateHighestCombo(currentCombo);
		currentCombo = 0;
	}

	//update the newest score to proper ScoreText 
	void UpdateScoreText() {
		scoreText.text = GetCalorie() + " Calories";
		greenRing.UpdatePosition ();

		//change gear speed

	}

	void UpdateHighestCombo(int curCombo) {
		if (curCombo > highestCombo) {
			highestCombo = curCombo;
		}
	}

	//returns Speed Multiplier value
	public float GetSpeedMultiplier() {
		if (totalHit / milestone > 1f) {
			//if (totalHit % milestone == 0) {
				speed += 10;
			milestone += 4;
				Debug.Log ("Change GEAR " + speed);
				//Debug.Log (speed);
			//}
		}
		return speed;
	}

	//returns current Calorie value
	public int GetCalorie() {
		return calorie;
	}

	//returns current Highest Combo value
	public int GetHighestCombo() {
		return highestCombo;
	}

	//returns current Total Miss value
	public int GetTotalMiss() {
		return totalMiss;
	}

	//it is Game Over
	void GameOver() {
		gameOver = true;
		Debug.Log ("Game Over");
		Time.timeScale = 0;

		//do effects and animation

		//enable GameOverCanvas
		gameOverCanvas.enabled = true;
		//(gameOverCanvas.GetComponentInChildren ("FinalScore") as MonoBehaviour).text = "howdy";
	}

	public bool isGameOver() {
		return gameOver;
	}

	public void RetryTheGame() {
		Application.LoadLevel ("Play");
		Time.timeScale = 1;
		//Destroy (this);
	}

	public void returnToMainMenu() {
		Application.LoadLevel ("mainMenu");
		Destroy (this);
	}

}
