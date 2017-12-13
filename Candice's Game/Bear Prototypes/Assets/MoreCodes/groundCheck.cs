using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour {

	public playerController playerScript;

	// Use this for initialization
	void Start () {
		playerScript = GetComponentInParent<playerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

/*	void OnTriggerEnter() {
		playerScript.isGrounded = true;
	}*/
		
	void OnTriggerStay(Collider other) {
		playerScript.isGrounded = true;

		if (other.tag == "Water") 
		{
			playerScript.inWater = true;
		}
	}

	void OnTriggerExit(Collider other) {
		playerScript.isGrounded = false;

		if (other.tag == "Water") 
		{
			playerScript.inWater = false;
		}
	}
}
