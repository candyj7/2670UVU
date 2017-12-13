using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LeechVision : MonoBehaviour {

	public static Action doSee;
	public static Action dontSee;

	// Use this for initialization
	void OnTriggerEnter ()
	{
		doSee ();
	}

	void OnTriggerExit()
	{
		dontSee ();
	}
}
