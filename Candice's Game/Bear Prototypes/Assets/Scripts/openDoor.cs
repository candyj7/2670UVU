using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
	public GameObject Door;
	// Use this for initialization
	void OnTriggerEnter() {
		//Door.transform.Translate(new Vector3(0,80,0)*Time.deltaTime);
		Door.SetActive(false);
	}

}
