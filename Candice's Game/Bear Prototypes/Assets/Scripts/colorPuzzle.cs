using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPuzzle : MonoBehaviour {

	public GameObject Door;

	public Renderer box1;
	public Renderer box2;
	public Renderer box3;

	public int b1;
	public int b2;
	public int b3;

	// Use this for initialization
	void Start ()
	{
		b1 = 1;
		b2 = 2;
		b3 = 3;
	}

	// Update is called once per frame
	void Update ()
	{
		if (b1 == 2 && b2 == 2 && b3 == 2)
		{
			OpenTheDoor ();
		}

		if (b1 > 3)
		{
			b1 = 1;
		}

		if (b2 > 3)
		{
			b2 = 1;
		}

		if (b3 > 3)
		{
			b3 = 1;
		}


		// Box1
		if (b1 == 1)
		{
			box1.material.color = new Color(1f, 0f, 1f, 1f);
		}
		else if (b1 == 2)
		{
			box1.material.color = new Color(0f, 1f, 1f, 1f);
		}
		else if (b1 == 3)
		{
			box1.material.color = new Color(1f, 0.92f, 0.016f, 1f);
		}

		// Box2
		if (b2 == 1)
		{
			box2.material.color = new Color(1f, 0f, 1f, 1f);
		}
		else if (b2 == 2)
		{
			box2.material.color = new Color(0f, 1f, 1f, 1f);
		}
		else if (b2 == 3)
		{
			box2.material.color = new Color(1f, 0.92f, 0.016f, 1f);
		}

		//Box3
		if (b3 == 1)
		{
			box3.material.color = new Color(1f, 0f, 1f, 1f);
		}
		else if (b3 == 2)
		{
			box3.material.color = new Color(0f, 1f, 1f, 1f);
		}
		else if (b3 == 3)
		{
			box3.material.color = new Color(1f, 0.92f, 0.016f, 1f);
		}

	}

	public void BoxNo1()
	{
		b1 += 1;
	}

	public void BoxNo2()
	{
		b2 += 1;
	}

	public void BoxNo3()
	{
		b3 += 1;
	}

	public void OpenTheDoor()
	{
		//Door.transform.Translate(new Vector3(0,80,0)*Time.deltaTime);
		Door.SetActive(false);
	}
}
