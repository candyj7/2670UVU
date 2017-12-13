using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class puzzleBox : MonoBehaviour {

	public colorPuzzle puzzle2;

	public int boxNumber;

	// Use this for initialization
	void Start ()
	{
		puzzle2 = GetComponentInParent<colorPuzzle>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter()
	{
		if (boxNumber == 1)
		{
			puzzle2.BoxNo1();
		}
		else if (boxNumber == 2)
		{
			puzzle2.BoxNo2();
		}
		else if (boxNumber == 3)
		{
			puzzle2.BoxNo3();
		}
	}
}
