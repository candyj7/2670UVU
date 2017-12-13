using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseEnemy : MonoBehaviour {

	public Animator anim;
	public bool chase;
	public Transform Player;
	public float MoveSpeed = 2;
	public float MaxDist = 5;
	public float MinDist = 2;

	Vector3 rotValue;
	Quaternion myRotate;

	void Start () 
	{
		
	}

	void Update () 
	{
		if (chase == true) {
			//transform.LookAt (Player);
			//transform.position += transform.forward * MoveSpeed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, Player.position, MoveSpeed * Time.deltaTime);

		} 
			
		//transform.LookAt(Player);

		//if(Vector3.Distance(transform.position,Player.position) >= MinDist)
			//{

			//transform.position += transform.forward*MoveSpeed*Time.deltaTime;


			//if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
			//{
				//Here Call any function U want Like Shoot at here or something
			//} 

		//}
	}

	void StartChase ()
	{
		chase = true;
		anim.SetBool ("fishswim", true);
	}

	void StopChase ()
	{
		chase = false;
		anim.SetBool ("fishswim", false);
	}

	void OnTriggerEnter ()
	{
		StartChase ();
	}

	void OnTriggerExit ()
	{
		StopChase ();
	}

	void OnTriggerStay ()
	{
		float newDistance = this.transform.position.x - Player.position.x;

		Flip(newDistance);
	}

	public void Flip(float obj)
	{
		{
			if (obj > 0)
				rotValue.y = 0;
			if (obj < 0)
				rotValue.y = 180;
		}

		myRotate.eulerAngles = rotValue;
		transform.rotation = myRotate;
	}
}
