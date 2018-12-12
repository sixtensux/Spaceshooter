using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingShotingEnemy : ShotingEnemy
{
	private float rndYPos; 
	private float rndIntensity;
	private float timeOfSpawn; 

	protected override void Start()
	{
		base.Start();
		timeOfSpawn = Time.time;
		rndYPos = Random.Range(-3f, 3f);
		rndIntensity = Random.Range(1.5f, 3f);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		transform.position = new Vector2(transform.position.x - speed, Mathf.Sin((Time.time - timeOfSpawn) * rndIntensity) + rndYPos);
	}
}
