using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class waterGravity : MonoBehaviour {

	public static Action waterEnter;
	public static Action waterExit;
	public static Action holdBreath;
	public static Action takeBreath;

	void OnTriggerEnter()
	{
		holdBreath ();
	}

	void OnTriggerStay()
	{
		waterEnter ();
	}

	void OnTriggerExit()
	{
		waterExit ();
		takeBreath ();
	}

}
