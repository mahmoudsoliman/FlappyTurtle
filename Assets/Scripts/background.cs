using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {
	
	public GameObject obj;

	public float deltaX=6;
	
	// Update is called once per frame
	void Update () {
		// to move the background with the player
		transform.Translate (new Vector3 (-obj.transform.position.x + transform.position.x-deltaX, 0, 0));
	}
}
