using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Ship : MonoBehaviour
{
	public int health;
	
	public Rigidbody2D rb;
	public GameObject deathEffect;//particleeffect on Death

	private float blinkTime;
	private float particleLifetime;
	private	 Color blinkColor = new Color(255, 0, 0, 255);

	public SpriteRenderer sprite;
	private Color initialColor;

	
	void Awake()
	{
		ParticleSystem particleSystem = deathEffect.GetComponent<ParticleSystem>();
		particleLifetime = particleSystem.main.duration;// finds the particle effect and it's duration

		rb = gameObject.GetComponent<Rigidbody2D>();

		sprite = GetComponent<SpriteRenderer>();
		if (sprite == null)
		{
			Debug.Log("Sprite is null wtf report");
		}

		initialColor = sprite.color;
		Debug.Log(sprite.color);
		initialColor.a = 1;
		blinkColor.a = 1;
	}

	private void StartBlink(float blinkTime)
	{
		this.blinkTime = Time.time + blinkTime;
	}

	protected virtual void Update()
	{
		sprite = GetComponent<SpriteRenderer>();

		if (Time.time < blinkTime)
		{
			sprite.color = blinkColor;
		}
		else
		{
			initialColor.a = 1;
			sprite.color = initialColor; 
		}
	}


	public virtual void TakeDamage(int Damage)
	{
		StartBlink(0.5f);
		health -= Damage;

		if (health <= 0)
		{
			Die();
		}
	}

	
	public virtual void Die()
	{
		//spawns hiteffect at current position
		GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);

		//destroys the particle effect after its duration is over
		Destroy(effect, particleLifetime);
		Destroy(gameObject);
	}
}
