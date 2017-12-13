using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class newPlayerInput : MonoBehaviour {
	public static Action<float> MoveAction;
	public static Action JumpAction;
	public static Action<float> ClimbAction;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if (JumpAction != null) 
			{
				JumpAction ();
			}
		}

		if (MoveAction != null) 
		{
			MoveAction (Input.GetAxis ("Horizontal"));
		}

		if (ClimbAction != null) 
		{
			ClimbAction (Input.GetAxis ("Vertical"));
		}
	}
}
