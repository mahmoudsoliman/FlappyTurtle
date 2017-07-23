using UnityEngine;
using System.Collections;

public class Digit : MonoBehaviour {

	public int power;
	public Texture[] frames1;
	public GUIText score;

	void Update () {
		if(score.text.Length>power)
			renderer.material.mainTexture = frames1 [
			                                        score.text [

			            score.text.Length-power-1]-'0'];
	}
}
