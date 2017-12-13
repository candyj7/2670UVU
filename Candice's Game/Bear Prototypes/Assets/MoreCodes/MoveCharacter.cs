using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;

	Vector3 tempMove;

	public float speed = 3;

	public float gravity = 1;

	public float jumpHeight = 1;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
		PlayButton.Play -= OnPlay;
	}

	void OnPlay (){
		MoveInput.JumpAction = Jump;
		MoveInput.KeyAction += Move;
		PlayButton.Play -= OnPlay;
	}

	public void Jump(){
		print("Jump");
		tempMove.y = jumpHeight;
	}    

	// Update is called once per frame
	void Move (float _movement) {
		tempMove.y -= gravity*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		print("move");
		cc.Move(tempMove);
	}
} 