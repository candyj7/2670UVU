using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BossAggro : MonoBehaviour {

	public static Action<Transform> passPlayer;
	public static Action endAggro;
	public Transform player;

	void OnTriggerEnter(Collider other)
	{
		player = other.transform;
		passPlayer (player);
	}

	void OnTriggerExit()
	{
		endAggro ();
	}

}
