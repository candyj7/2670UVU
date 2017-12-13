using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bounceScript : MonoBehaviour {

	public static Action bounceAction;

	void OnTriggerEnter ()
	{
		bounceAction ();
		print ("myfault");
	}
}