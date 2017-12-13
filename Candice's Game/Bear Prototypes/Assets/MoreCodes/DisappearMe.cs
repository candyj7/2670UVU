using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearMe : MonoBehaviour {

	public bool useGravity;
	GameObject platform;

	public GameObject playerLocater;
	// Use this for initialization
	void Start () {
		playerLocater = GameObject.Find("obj_Player");
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision DisappearMe) 
	{
		if (DisappearMe.gameObject.name == "obj_Player") 
		{
			print ("Poof");
		}	
	}
}
