using UnityEngine;

public class TankEnemy : BasicEnemy
{		
public override void OnTriggerEnter2D(Collider2D hitInfo)
	{
		base.OnTriggerEnter2D(hitInfo);

		if (hitInfo.tag == "Player")
		{
			PlayerShip Player = hitInfo.GetComponent<PlayerShip>();

			if (Player != null)
			{
				Player.TakeDamage(Damage);
			}
		}
	}
}
