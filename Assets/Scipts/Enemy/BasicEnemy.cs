﻿using UnityEngine;

public class BasicEnemy : Ship
{
	private GameObject gameController;
	public ScoreUpdater score;
	public int points = 10;
	public float speed = 10;
	public float despawnTime = 5f;

	private float time;
	public int Damage = 1;

	private bool isDespawning = false;// a bool to determinate if the player should earn points when the game object is destroyed

	protected virtual void Start()
	{
		gameController = GameObject.FindWithTag("GameController");
		score = gameController.GetComponent<ScoreUpdater>();
	}
	
	protected virtual void FixedUpdate()//moves ship
	{
		base.rb.transform.Translate(new Vector2((-1 * speed), 0));

		time += Time.deltaTime;

		if (time > despawnTime)
		{
			Despawn();
		}
	}

	//ship "dies" when colliding with the Player damaging the player in the process
	public virtual void OnTriggerEnter2D(Collider2D hitInfo)
	{
		
		if (hitInfo.tag == "Player")
		{	
			PlayerShip Player = hitInfo.GetComponent<PlayerShip>(); //damages the player on collision default damage is 1

			
			//null check
			if (Player != null)
			{
				Player.TakeDamage(Damage);
			}
			Die();
		}
	}

	//removes the gameobject (does not award the player points)
	private void Despawn()
	{
		isDespawning = true; // when is despawning = true it does'nt award any points for being destroyed
		Destroy(gameObject);
	}

	//awards the player with points when an enemy is destroyed (does not award points for despawning enemies)
	private void OnDestroy()
	{
		if (! isDespawning)
		{
			score.AddPoints(points); 
		}
	}
}
