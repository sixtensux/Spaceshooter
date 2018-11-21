using UnityEngine;

public class Projectile : MonoBehaviour {

    public int damage = 1;
    public Rigidbody2D rb;
    public float bulletSpeed = 10f;


	public float time;
	public float despawnTime = 5f;

	private float particleLifetime; //Lifetime of impactEffect
	public GameObject hiteffect;
	private bool HitWall;

	void Start ()
    {
		ParticleSystem particleSystem = hiteffect.GetComponent<ParticleSystem>();
		particleLifetime = particleSystem.main.duration;

        rb = gameObject.GetComponent<Rigidbody2D>();
    }

	public virtual void FixedUpdate()
	{

		rb.velocity = bulletSpeed * transform. up;

		time += Time.deltaTime;

		if (time > despawnTime)
		{
			Hit();
		}
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Ship Enemy = hitInfo.GetComponent<Ship>();
        if(Enemy != null)
        {
            Enemy.TakeDamage(damage);
        }

		if (hitInfo.name == "wall")
		{
			HitWall = true;
		}


		Hit();
    }

	public void Hit()
	{
		if (HitWall != true)
		{
		//spawns hiteffect at current position
		GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);

		//destroys the particle effect after its duration is over
		Destroy(effect, particleLifetime);
		}
		Destroy(gameObject);
	}
}
