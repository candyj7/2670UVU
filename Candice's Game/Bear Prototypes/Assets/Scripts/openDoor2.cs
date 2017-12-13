using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor2 : MonoBehaviour {
		public GameObject Door2;
		// Use this for initialization
		void OnTriggerEnter() {
			Door2.transform.Translate(new Vector3(-280,0,0)*Time.deltaTime);

	}
}
