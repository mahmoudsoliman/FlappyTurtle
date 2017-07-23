using UnityEngine;
using System.Collections;

public class obstacles : MonoBehaviour {
	public GameObject obstacle;
	public float maxY;
	public float minY;
	public float newX;
	public float maxDeltaY;
	public float space;
	public int deltaTime;
	public GUIText score;
	private float deltaY;
	public static int points;
	private float time;
	private float iniTime;
	public float turtleX;
	
	// Use this for initialization
	void Start () {
		points = 0;
		deltaY = (maxY + minY) / 2;
		time = 0;
		iniTime = (newX+turtleX)/Movement.horizontalSpeed;
		//score.text="Score:"+point.5fs;
	}
	
	// Update is called once per frame
	void Update () {
		if (Movement.dead)
			return;
		if (!Movement.started) {
			iniTime+=Time.deltaTime;
			time+=Time.deltaTime;
			return;
				}
		if (Time.timeSinceLevelLoad >= iniTime) {
			score.text=(++points).ToString();
			iniTime+=deltaTime;
		}
		if(Time.timeSinceLevelLoad>=time){
			time+=deltaTime;
			float rand=Random.Range(Mathf.Max(deltaY-maxDeltaY, minY),Mathf.Min(deltaY+maxDeltaY, maxY));
			Instantiate(obstacle,new Vector3(transform.position.x+newX,rand,0.1F),new Quaternion(0,180,0,0));
			Instantiate(obstacle,new Vector3(transform.position.x+newX,rand+obstacle.renderer.bounds.size.y+space,0.1F),new Quaternion(0,0,0,0));
		}
	}
}
