using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMotor : MonoBehaviour {

	public Rigidbody bossRB;
	public Transform target;

	public float waitTime_1;
	public float waitTime_2;
	public float jumpHeight;
	public float moveSpeed;
	public float playerDir;

	public bool isAggro;

	// Use this for initialization
	void Start () 
	{
		bossRB = GetComponent<Rigidbody> ();
		isAggro = false;
		BossAggro.passPlayer += BossIsAggro;
		BossAggro.endAggro = BossNotAggro;
	}
		
	// Update is called once per frame
	void Update () 
	{
		if (target != null) 
		{
			float playerDist = this.transform.position.x - target.position.x;

			if (playerDist > 0) {
				playerDir = -1;
			} 
			else if (playerDist < 0) 
			{
				playerDir = 1;
			}
		}	
	}
	IEnumerator BossMovement()
	{
		if (isAggro) {
			bossRB.velocity = new Vector3 (playerDir * moveSpeed * Time.deltaTime, jumpHeight * Time.deltaTime, 0); 
		} 
		else 
		{
			yield break;
		}

		yield return new WaitForSeconds (waitTime_1);

		if (isAggro) {
			bossRB.velocity = new Vector3 (playerDir * moveSpeed * Time.deltaTime, jumpHeight * Time.deltaTime, 0); 
		} 
		else 
		{
			yield break;
		}

		yield return new WaitForSeconds (waitTime_1);

		if (isAggro) {
			bossRB.velocity = new Vector3 (playerDir * moveSpeed * Time.deltaTime, jumpHeight * Time.deltaTime, 0); 
		} 
		else 
		{
			yield break;
		}

		yield return new WaitForSeconds (waitTime_2);

		if (isAggro) {
			StartCoroutine (BossMovement ()); 
		} 
		else 
		{
			yield break;
		}



	}//end of Coroutine

	void BossIsAggro (Transform _player)
	{
		target = _player;
		isAggro = true;
		StartCoroutine (BossMovement ());  
	}

	void BossNotAggro()
	{
		isAggro = false;
	}

}
