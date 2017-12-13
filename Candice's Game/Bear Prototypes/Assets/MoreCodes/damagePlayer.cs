using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class damagePlayer : MonoBehaviour {

	public static Action<float> damageAction;
	public float damageAmount;

	void OnTriggerEnter()
	{
		damageAction (damageAmount);
	}

}
