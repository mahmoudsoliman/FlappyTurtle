using UnityEngine;
using System.Collections;

public class GetReady : MonoBehaviour {
	
	private float time;
	
	void Start(){

	}
	
	void Update () {
		// remove the word "get ready"
		if (Movement.started)
			Destroy (gameObject);
	}
}
