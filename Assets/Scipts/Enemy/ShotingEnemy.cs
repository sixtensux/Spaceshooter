using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingEnemy : BasicEnemy
{
	public GameObject firePoint;
	public GameObject projectile;

	private float nextFire = 4F;//initial shot
	public float FireDelay = 2F;//delay between shots

	private GameObject newProjectile;



	void Update()
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + FireDelay;
			newProjectile = Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
		}

	}
}