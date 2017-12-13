using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {

	public Animator anim;

	public GameObject startButton;
	public GameObject quitButton;

	public float canShowUI;

	// Use this for initialization
	void Start () 
	{
		canShowUI = 0;	
	}

	/*void OnEnable()
	{
		SceneManager.sceneLoaded += OnFinishedLoading;
	}*/	

	// Update is called once per frame
	void Update () 
	{
		if (canShowUI == 1) 
		{
			startButton.SetActive (true);
			quitButton.SetActive (true);
		} 
		else if (canShowUI == 0) 
		{
			startButton.SetActive (false);
			quitButton.SetActive (false);
		}
	}

	public void UIAppear(float showUI)
	{
		canShowUI = showUI;
	}

	public void LoadLevel()
	{
		SceneManager.LoadScene("Prototype One");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	/*void OnDisable()
	{
		SceneManager.sceneLoaded -= OnFinishedLoading;
	}

	void OnFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		anim.SetBool ("playIntro", true);
		print ("something's wrong");
	}

	public void EndIntro()
	{
		anim.SetBool ("playIntro", false);
	}*/
}
