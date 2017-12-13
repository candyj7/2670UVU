using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerController : MonoBehaviour {


	public Animator anim;

	public Rigidbody playerBody;
	public float MoveSpeed;
	public float JumpSpeed;
	public bool isGrounded;
	public bool doubleJumped;
	public bool facingRight;
	public bool inWater;
	public float waterGravity;
	// Use this for initialization
	void Start () 
	{
		playerBody = GetComponent<Rigidbody>();
		facingRight = true;
		inWater = false;
	}




	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			playerBody.velocity = new Vector3 (-MoveSpeed, playerBody.velocity.y, 0);

			if (facingRight == true) 
			{
				Flip ();
				facingRight = false;
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			playerBody.velocity = new Vector3 (MoveSpeed, playerBody.velocity.y, 0);

			if (facingRight == false) 
			{
				Flip ();
				facingRight = true;
			}
		}

	}





	void Update () 
	{
		if (isGrounded == true) 
		{
			doubleJumped = false;
		}

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Jump ();
		}

		if (inWater == true) 
		{
			if (playerBody.velocity.y < -1) 
			{
				playerBody.AddForce (transform.up * waterGravity);
			}
		}


	}

	void Jump()
	{
		if (isGrounded == true) 
		{
			playerBody.velocity = new Vector3 (0, JumpSpeed, 0);
		}

		if (isGrounded == false && doubleJumped == false) 
		{
			playerBody.velocity = new Vector3 (0, JumpSpeed, 0);
			doubleJumped = true;
		}

	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
