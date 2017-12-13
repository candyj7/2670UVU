using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPhysics : MonoBehaviour {

	public Rigidbody ballBody;

	public float maxVelocity;

	// Use this for initialization
	void Start () 
	{
		ballBody = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ballBody.velocity = Vector3.ClampMagnitude (ballBody.velocity, maxVelocity);

	}
}
