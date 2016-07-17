using UnityEngine;
using System.Collections;

public class GreenRingBehavior : MonoBehaviour {
	
	public GameManager gameManager;
	private int currentCalorie;

	// Use this for initialization
	void Start () {
		currentCalorie = gameManager.GetCalorie();
		UpdatePosition ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.touchCount > 0) {
		//	UpdatePosition ();
		//}
	}

	public void UpdatePosition() {
		//transform.Rotate(Vector3.back, 180f);
		//Debug.Log("Z axis" + transform.eulerAngles.z);
		transform.Rotate(Vector3.back, Random.Range(1f,15f) * 20);
		//transform.eulerAngles.z
	}

}
