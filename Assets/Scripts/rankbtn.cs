using UnityEngine;
using System.Collections;

public class rankbtn : MonoBehaviour {
	// show ranks
	void OnMouseDown(){
		Application.LoadLevel ("Ranks");
	}  
	void Update()
	{
		if (play.playBtnTapped == true)
						Destroy (gameObject);
	}
}
