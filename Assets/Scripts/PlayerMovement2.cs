using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

    [SerializeField]
    private float jumpHeight = 6;

    private Rigidbody2D rb;

    private int jumpPoints = 2;

    float horizontalInput;

    public float speed = 10;

    public Animator anim;

    private bool facingRight = true;

    AudioSource au;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpPoints = 2;
        anim.SetBool("IsInAir", false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pickup")
        {
            jumpPoints = 2;

        }
    }

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        au = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
        horizontalInput = Input.GetAxis("Horizontal");
	}

    private void FixedUpdate()
    {
        HandleWalking();
        HandleJumping();
    }

    private void HandleWalking()
    {


        rb.velocity = new Vector2(speed * horizontalInput, rb.velocity.y);
        anim.SetFloat("Speed",Mathf.Abs(horizontalInput));

        if (horizontalInput > 0 && !facingRight)
            Flip();
        else if (horizontalInput < 0 && facingRight)
            Flip();

    }

    private void HandleJumping()
    {
        if (Input.GetButtonDown("Jump") && (jumpPoints > 0))
        {
            jumpPoints--;
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            anim.SetBool("InInAir", true);
            au.Play();

        }

    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
}
