using UnityEngine;
using System.Collections;

public class SliderArrowBehavior : MonoBehaviour {

	public GameManager gameManager;
	private bool isPaused = false;
	private bool meetGreen = false;
	private int curCalorie;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.touchCount > 0) {
			//ambil touch pertama, phase begin, buat kasih command ke cube
			//cek apakah collision or not
		if (!gameManager.isGameOver()) {
			if (Input.GetMouseButtonDown (0)) {
				if (meetGreen) {
					gameManager.AddScoreHit ();
					Debug.Log ("Input and Hit");
					Debug.Log (gameManager.GetCalorie ());
					//meetGreen = false;
				} else {
					gameManager.AddScoreHitnMiss ();
					Debug.Log ("Input and Miss");
					Debug.Log (gameManager.GetCalorie ());
				}
			}

			if (Input.touchCount > 0) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					if (meetGreen) {
						gameManager.AddScoreHit ();
						Debug.Log ("Input and Hit");
						Debug.Log (gameManager.GetCalorie ());
						//meetGreen = false;
					} else {
						gameManager.AddScoreHitnMiss ();
						Debug.Log ("Input and Miss");
						Debug.Log (gameManager.GetCalorie ());
					}
				}
			}
		}

		//}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "greenArea") {
			meetGreen = true;
			curCalorie = gameManager.GetCalorie();
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "greenArea") {
			if (curCalorie == gameManager.GetCalorie()) {
				Debug.Log ("Miss");
				//TODO: we have to UpdatePosition too
				gameManager.MissTheGreen();
			}
			meetGreen = false;
		}
	}
}
