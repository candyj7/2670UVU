using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class healPlayer : MonoBehaviour {

	public static Action<float> healAction;
	public float healAmount;

	void OnTriggerEnter()
	{
		healAction (healAmount);
		this.gameObject.SetActive (false);
	}
}
