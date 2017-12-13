using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetMeFall : MonoBehaviour {
	public bool useGravity;
	GameObject platform;

	void OnControllerColliderHit(ControllerColliderHit hit)
	{

		if (hit.gameObject.tag == "platform") 
		{
			platform = hit.gameObject;
			Invoke ("Fall", 0.2f);
		}
	}

	void Fall()
	{
		platform.GetComponent<Rigidbody> ().useGravity = true;
	}
}