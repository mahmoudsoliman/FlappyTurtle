using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	public GUITexture getReady;

	public GUITexture tap;

	public static bool playBtnTapped = false;

	public static int tapCounter = 0;

	void Start(){
		playBtnTapped = false;
		tapCounter = 0;
	}

	void Update(){
		if (Input.GetKey ("escape"))
			Application.Quit ();
	}

	//opens the game play
	void OnMouseDown(){
		playBtnTapped = true;
		tapCounter = 1;
		getReady.color =new Color(getReady.color.r,getReady.color.g,getReady.color.b,255);
		tap.color =new Color(tap.color.r,tap.color.g,tap.color.b,255);
		Destroy (gameObject);
	}   
}
