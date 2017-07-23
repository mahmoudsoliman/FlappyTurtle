using UnityEngine;
using System.Collections;

public class ranks : MonoBehaviour {

	public GUIText first;
	public GUIText second;
	public GUIText third;

	// Use this for initialization
	void Start () {
		// setting ranks to 0 in the first time you play the game
		if(! PlayerPrefs.HasKey("one" ))
			PlayerPrefs.SetInt( "one", 0 );
		if(! PlayerPrefs.HasKey("two" ))
			PlayerPrefs.SetInt( "two", 0 );
		if(! PlayerPrefs.HasKey("three" ))
			PlayerPrefs.SetInt( "three", 0 );
		first.text = PlayerPrefs.GetInt ("one").ToString ();
		second.text = PlayerPrefs.GetInt ("two").ToString ();
		third.text = PlayerPrefs.GetInt ("three").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))
			Application.LoadLevel ("1");
	}
}
