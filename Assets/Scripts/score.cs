using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	void Start () {
		guiText.text = obstacles.points.ToString();
	}

}
