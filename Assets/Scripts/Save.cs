using UnityEngine;
using System.Collections;

public class Save : MonoBehaviour {

	private int MyScore;
	public static int best;

	// Use this for initialization
	void Start () {
		MyScore = obstacles.points;

		// setting ranks to 0 in the first time you play the game
		if(! PlayerPrefs.HasKey("one" ))
			PlayerPrefs.SetInt( "one", 0 );
		if(! PlayerPrefs.HasKey("two" ))
			PlayerPrefs.SetInt( "two", 0 );
		if(! PlayerPrefs.HasKey("three" ))
			PlayerPrefs.SetInt( "three", 0 );
		// ddisplay the player score

		SetHighscore ();
	}
	
	// Update is called once per frame
	void Update () {
		// tap to return to the main menu
		if (Input.GetMouseButtonDown (0))
				Application.LoadLevel ("1");
	}
	// setHighScore checks the player rank and save it if he is from the top three scores
	void SetHighscore()
	{

		if (PlayerPrefs.GetInt ("one") <= MyScore) {
						PlayerPrefs.SetInt ("three", PlayerPrefs.GetInt ("two"));
						PlayerPrefs.SetInt ("two", PlayerPrefs.GetInt ("one"));
						PlayerPrefs.SetInt ("one", MyScore);
				}
		else if (PlayerPrefs.GetInt ("two") <= MyScore) {
						PlayerPrefs.SetInt ("three", PlayerPrefs.GetInt ("two"));
						PlayerPrefs.SetInt ("two", MyScore);
				} 
		else if (PlayerPrefs.GetInt ("three") <= MyScore) {
						PlayerPrefs.SetInt ("three", MyScore);
				}
		guiText.text = PlayerPrefs.GetInt("one").ToString();

		//PlayerPrefs.DeleteAll ();

		PlayerPrefs.Save();
	}

}
