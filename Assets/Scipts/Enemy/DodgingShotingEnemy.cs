﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingShotingEnemy : ShotingEnemy {

	private float rndYPos; // Mathf.Sin fucks up the random Y from the original spawn so I did the lazy thing and assigned a new pos
	private float rndIntensity;
	private float timeOfSpawn; // makes it so that the enemies are out of sync.

	private void Start()
	{
		timeOfSpawn = Time.time;
		rndYPos = Random.Range(-3f, 3f);
		rndIntensity = Random.Range(1.5f, 3f);
	}

	public override void FixedUpdate()
	{
		transform.position = new Vector2(transform.position.x - speed, Mathf.Sin((Time.time - timeOfSpawn) * rndIntensity) + rndYPos);
	}
}
