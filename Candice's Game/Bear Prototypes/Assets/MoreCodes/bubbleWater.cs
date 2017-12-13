using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bubbleWater : MonoBehaviour {

	public static Action<float> airGulp;
	public float airAmount;

	// Use this for initialization
	void OnTriggerEnter ()
	{
		airGulp (airAmount);
		StartCoroutine ("BubbleRespawn");
	}

	IEnumerator BubbleRespawn ()
	{
		this.gameObject.SetActive (false);
		yield return new WaitForSeconds(5);
		this.gameObject.SetActive (true);
	}
}
