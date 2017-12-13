using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class pauseManager : MonoBehaviour {

	public static Action<bool> pauseAction;

	public GameObject pauseImage;

	public GameObject resumeButton;

	public GameObject mainMenuButton;

	public bool isPaused;

	// Use this for initialization
	void Start () 
	{
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			if (isPaused == false) {
				isPaused = true;
			} else if (isPaused == true) 
			{
				isPaused = false;
			}
		}

		if (isPaused == true) 
		{
			Time.timeScale = 0;
			pauseAction (true);
			pauseImage.SetActive (true);
			resumeButton.SetActive (true);
			mainMenuButton.SetActive (true);
		}
		else if(isPaused == false)
		{
			Time.timeScale = 1;
			pauseAction (false);
			pauseImage.SetActive (false);
			resumeButton.SetActive (false);
			mainMenuButton.SetActive (false);
		}
	}

	public void Unpause()
	{
		isPaused = false;
	}

	public void LoadMenu()
	{
		isPaused = false;
		SceneManager.LoadScene("MainMenu");
	}
}
