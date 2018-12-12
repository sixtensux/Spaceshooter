using UnityEngine;

public class Shooting : MonoBehaviour 
{
	//projectile and timer
	[Range(0, 1)] //public for easy access and adjustments
    public float fireDelay;
	public GameObject projectile;

    private float counter = 0.0F;
    private float nextFire = 0.5F;

	//audio
	private new AudioManager audio;
    private GameObject newProjectile;

	private void Awake()
	{
		audio = FindObjectOfType<AudioManager>();
	}

	void Update()
	{
        counter = counter + Time.deltaTime;

		//triggers the function once every "fireDelay" while holding "Fire1"(Left mouse button || Left-Ctrl)
		if (Input.GetButton("Fire1") && counter > fireDelay) 
        {
            nextFire = counter + fireDelay; 
            newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
		    audio.Play("Pew");
			nextFire = nextFire - counter;
            counter = 0.0F;
        }
    }
}