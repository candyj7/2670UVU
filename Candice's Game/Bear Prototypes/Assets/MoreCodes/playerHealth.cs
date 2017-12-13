using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerHealth : MonoBehaviour {

	public static Action healthDepletedAction;
	public float currentHealth;
	public float maxHealth;
	public float minHealth;
	public float currentOxy;
	public float maxOxy;
	public float minOxy;
	public Animator healthAnim;
	public Animator oxyAnim;

	// Use this for initialization
	void Start () 
	{
		healPlayer.healAction += GainHealth;
		damagePlayer.damageAction += LoseHealth;
		newPlayerMotor.respawnAction = FullHealth;
		waterGravity.holdBreath = LoseOxy;
		waterGravity.takeBreath = FullOxy;
		bubbleWater.airGulp += GainOxy;
		healthAnim.SetFloat ("Health", currentHealth);
		oxyAnim.SetFloat ("Oxygen", currentOxy);
	}

	void LoseHealth (float damage)
	{
		currentHealth -= damage;

		if (currentHealth <= minHealth) 
		{
			healthDepletedAction ();
		}

		healthAnim.SetFloat ("Health", currentHealth);
		print (currentHealth);
	}

	void GainHealth (float heal)
	{
		currentHealth += heal;

		if (currentHealth >= maxHealth) 
		{
			currentHealth = maxHealth;
		}

		healthAnim.SetFloat ("Health", currentHealth);

		print (currentHealth);
	}

	void FullHealth (bool respawned)
	{
		if (respawned == true) {
			currentHealth = maxHealth;
			healthAnim.SetFloat ("Health", currentHealth);
			FullOxy ();
		} 
		else if (respawned == false) 
		{
			currentHealth = minHealth;
			healthAnim.SetFloat ("Health", currentHealth);
		}
	}

	public void LoseOxy () 
	{
		StartCoroutine ("Drowning");
	}

	public void GainOxy (float oxyGain)
	{
		currentOxy += oxyGain;

		if (currentOxy >= maxOxy) 
		{
			currentOxy = maxOxy;
		}

		//StartCoroutine ("Drowning");

		oxyAnim.SetFloat ("Oxygen", currentOxy);
	}

	public void FullOxy ()
	{
		StopCoroutine ("Drowning");
		currentOxy = maxOxy;
		oxyAnim.SetFloat ("Oxygen", currentOxy);
		print ("freshair");
	}

	IEnumerator Drowning()
	{
		currentOxy -= 1;
		yield return new WaitForSeconds (0.3f);
		oxyAnim.SetFloat ("Oxygen", currentOxy);

		if (currentOxy <= minOxy) {
			currentOxy = minOxy;
			LoseHealth (100);
		} 
		else
		{
			LoseOxy ();
		}
	}
		
}
