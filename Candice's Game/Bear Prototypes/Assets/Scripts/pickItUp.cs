using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickItUp : MonoBehaviour {

	public Animator anim;

	public Transform Sphere;

	public bool carrying;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (carrying == true) 
		{
			Sphere.parent = this.transform;
			Sphere.position = this.transform.position;
			anim.SetBool ("carry", true);
		} 
		else if(carrying == false)
		{	
			if (Sphere != null)
			{
				Sphere.transform.parent = null;
			}
			anim.SetBool ("carry", false);
		}
	}

	void OnTriggerStay(Collider other)
	{
		Sphere = other.GetComponent<Transform> ();

		if (Input.GetKeyDown(KeyCode.Z)) 
		{
			if (carrying == false) 
			{
				carrying = true;
			} 
			else if (carrying == true)
			{
				carrying = false;
			}
		}
	}

}
