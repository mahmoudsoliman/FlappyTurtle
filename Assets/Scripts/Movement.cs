using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	
	public float FPS;
	public Texture[] frames;
	static public float horizontalSpeed;
	public float horiSpeed;
	public float gravity;
	public float verticalSpeed;
	public float secondsBeforeLoading;
	public float loadingTime;
	static public float waitingTime;
	public float yMax;
	public static bool started = false;
	
	private float secondsToWait;
	private int currentFrame;
	private float verticalVelocity;
	private bool loop;
	static public bool dead;
	private float secondsAfterDeath;
	private bool instant = false;
	
	public GameObject cam;
	
	public GameObject scoreBoard;
	
	void Start()
	{
		waitingTime = 0;
		renderer.material.mainTexture = frames[0];
		horizontalSpeed = horiSpeed;
		loop = true;
		dead = false;
		secondsToWait = 1 / FPS;
		currentFrame = 0;
		secondsAfterDeath = 0;
		StartCoroutine(Animate());
		started = false;
	}
	
	IEnumerator Animate()
	{
		bool stop = false;
		if (currentFrame >= frames.Length - 1)
			if (loop == false)
				stop = true;
		else
			currentFrame = 0;
		yield return new WaitForSeconds(secondsToWait);
		renderer.material.mainTexture = frames[currentFrame];
		currentFrame++;
		if (stop == false)
			StartCoroutine(Animate());
	}
	
	void Update()
	{
		if (loop && Input.GetMouseButtonDown(0))
		{
			play.tapCounter++;
			print (play.tapCounter);
			if (!started &&play.tapCounter == 3)
				started = true;
			verticalVelocity = verticalSpeed;
		}
		if (!started)
		{
			waitingTime += Time.deltaTime;
			transform.Translate(new Vector3(-Time.deltaTime * horizontalSpeed,0, 0));
			return;
		}
		if (!loop)
		{
			secondsAfterDeath += Time.deltaTime;
			loop = false;
			rigidbody.useGravity = true;
		}
		if (secondsBeforeLoading <= secondsAfterDeath && !instant)
		{
			instant = true;
			Instantiate(scoreBoard, new Vector3(0.5F, 0.5F, 0), Quaternion.identity);
		}
		if (secondsBeforeLoading <= secondsAfterDeath && Input.GetMouseButton(0))
		{
			Application.LoadLevel("MainMenu");
		}
		if (transform.position.y > yMax && verticalVelocity > 0)
		{
			verticalVelocity = 0;
		}
		if (loop)
		{
			transform.Translate(new Vector3(-Time.deltaTime * horizontalSpeed, Time.deltaTime * verticalVelocity, 0));
		}
		verticalVelocity -= gravity * Time.deltaTime;
		if (loop && Input.GetMouseButtonDown(0))
		{
			verticalVelocity = verticalSpeed;
		}
	}
	void OnCollisionEnter(Collision col)
	{
		loop = false;
		verticalVelocity = 0;
		dead = true;
	}
}
