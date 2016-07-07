using UnityEngine;
using System.Collections;

public class SliderRingBehavior : MonoBehaviour {
	public GameManager gameManager;
	//float speed;

	void Start() {
		//speed = 50f;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back, Time.deltaTime * gameManager.GetSpeedMultiplier());
	}
}
