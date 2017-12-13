using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapScript : MonoBehaviour {

	public GameObject trapDoor;
	// Use this for initialization
	void OnTriggerExit() 
	{
		trapDoor.SetActive(false);
	}
}
