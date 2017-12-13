using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {

	//public AudioClip[] musicList;

	public AudioSource areaSong;

	// Use this for initialization
	void Start () 
	{
		areaSong = GetComponent<AudioSource> ();
		areaSong.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter()
	{
		areaSong.Play ();
	}

	void OnTriggerExit()
	{
		areaSong.Stop ();
	}
}
