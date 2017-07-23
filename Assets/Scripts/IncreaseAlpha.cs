using UnityEngine;
using System.Collections;

public class IncreaseAlpha : MonoBehaviour {
	
	private float time;
	
	void Start(){
		// how many seconds the texture of "tap" is displayed
		time = Movement.waitingTime;
	}
	
	void Update () {
		//to make it desapear slowly

		if(Movement.started)
		if(guiTexture.color.a>0)
			guiTexture.color =new Color(guiTexture.color.r,guiTexture.color.g,guiTexture.color.b,guiTexture.color.a-Time.deltaTime/time);
	}
}
