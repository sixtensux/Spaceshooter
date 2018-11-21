using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f;           

    private Rigidbody2D rb;
    private Vector2 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public  void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            speed = 5;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            speed = 10;
        }
    }
   

    void FixedUpdate()
    { 
		float moveHorizontal= Input.GetAxisRaw("Horizontal");
		float moveVertical  = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
    } 
}