using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class newPlayerMotor : MonoBehaviour {

	public static Action<bool> respawnAction;

	public CharacterController cc;

	public Animator anim;

	public float gravity;
	public float moveSpeed;
	public float jumpSpeed;
	public float climbSpeed;

	public bool doubleJump;
	public bool swimming;
	public bool canClimb;
	public bool gamePause;

	public Renderer playerRenderer;

	public Transform spawnPoint;

	private Vector3 moveDir;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		newPlayerInput.MoveAction += Move;
		newPlayerInput.JumpAction = Jump;
		waterGravity.waterEnter = InWater;
		waterGravity.waterExit = OutWater;
		DeathRespawn.deathAction = Death;
		playerHealth.healthDepletedAction = Death;
		bounceScript.bounceAction = Bounce;
		climbScript.climbAble += ClimbState;
		newPlayerInput.ClimbAction += Climb;
		pauseManager.pauseAction += PauseTheGame;
		canClimb = false;
	}

	
	// Update is called once per frame
	void Update () 
	{
		if (cc.isGrounded == true || gamePause == true) 
		{
			moveDir.y = 0;
			print ("ground");
		}

		if (cc.isGrounded) 
		{
			anim.SetBool ("jump", false);
		}
	}

	public void Jump()
	{
		if (cc.isGrounded == true) 
		{
			if (swimming == false) 
			{
				moveDir.y = jumpSpeed * Time.deltaTime;
				anim.SetBool ("jump", true);
				doubleJump = false;
			} 
			else 
			{
				moveDir.y = jumpSpeed / 3f * Time.deltaTime;
				doubleJump = false;
			}
		}

		if (cc.isGrounded == false && doubleJump == false) 
		{
			if (swimming == false) 
			{
				moveDir.y = jumpSpeed * Time.deltaTime;
				anim.SetBool ("jump", true);
				doubleJump = true;
			} 
			else 
			{
				moveDir.y = jumpSpeed / 3f * Time.deltaTime;
				doubleJump = false;
			}
		}

	}//END JUMP

	void Move(float movement)
	{
		if (swimming == false) {
			moveDir.y -= gravity * Time.deltaTime;
			if (movement != 0) {
				anim.SetBool ("run", true);
				anim.SetBool ("swim", false);
			} else 
			{
				anim.SetBool ("run", false);
			}
		} 
		else if (swimming == true) 
		{
			moveDir.y -= gravity / 10 * Time.deltaTime;
			anim.SetBool ("swim", true);
		}

		moveDir.x = movement * moveSpeed * Time.deltaTime;
		cc.Move (moveDir);
	}//END MOVE

	void Climb(float climbDir)
	{
		if (canClimb == true) {
			gravity = 0;
			newPlayerInput.JumpAction -= Jump;
			moveDir.y = climbDir * climbSpeed * Time.deltaTime;
			moveDir.x = 0;
			cc.Move (moveDir);
			anim.SetBool ("climb", true);
		} 
		else 
		{
			gravity = 0.2f;
			newPlayerInput.JumpAction = Jump;
			anim.SetBool ("climb", false);
		}
	}

	void ClimbState(bool climbing)
	{
		canClimb = climbing;
	}

	public void InWater()
	{
		swimming = true;
		print ("hi");
	}

	public void OutWater()
	{
		swimming = false;
	}

	public void Death()
	{
		StartCoroutine ("Respawn");
	}

	IEnumerator Respawn()
	{
		playerRenderer.enabled = false;
		gravity = 0;
		moveDir.y = 0;
		respawnAction (false);
		newPlayerInput.MoveAction -= Move;
		yield return new WaitForSeconds (2);
		this.transform.position = spawnPoint.position;
		newPlayerInput.MoveAction += Move;
		gravity = 0.2f;
		playerRenderer.enabled = true;
		respawnAction (true);
	}

	void Bounce ()
	{
		moveDir.y = jumpSpeed * 1.5f * Time.deltaTime;
		doubleJump = false;
		print ("bounce");
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "CheckPoint") 
		{
			spawnPoint = other.gameObject.transform;
		}
	}

	void PauseTheGame(bool isPaused)
	{
		gamePause = isPaused;
	}
}
