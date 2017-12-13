using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeathRespawn : MonoBehaviour {
	
	public static Action deathAction;
	public Collider deathCollider;

	void Start()
	{
		deathCollider = GetComponent<Collider> ();
	}

	void OnTriggerEnter()
	{
		deathAction ();
		StartCoroutine ("TriggerReset");
	}

	IEnumerator TriggerReset()
	{
		deathCollider.enabled = false;
		yield return new WaitForSeconds (3f);
		deathCollider.enabled = true;
	}
		
}
