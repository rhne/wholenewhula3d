﻿using UnityEngine;
using System.Collections;

public class DestroyInstance : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, this.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).length);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
