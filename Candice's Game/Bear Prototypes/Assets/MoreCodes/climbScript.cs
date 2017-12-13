using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class climbScript : MonoBehaviour {

	public static Action <bool> climbAble;

	void OnTriggerEnter ()
	{
		climbAble (true);
	}

	void OnTriggerExit ()
	{
		climbAble (false);
	}
}
