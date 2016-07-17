using UnityEngine;
using System.Collections;

public class EffectController : MonoBehaviour {
	public GameObject nicePrefab;

	public void InstantiateEffectNice(GameObject layer) {
		Instantiate (nicePrefab, layer.transform.position, layer.transform.rotation);
	}


}
