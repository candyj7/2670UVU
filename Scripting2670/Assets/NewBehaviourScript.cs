using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour
{

    Action KeyAction;

    private void Start()
    {
        KeyAction = Move;
    }

    //Use this for initialization
    void Move () {
        print("Left Arrow");
    }

    //Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        KeyAction();
        }
    }
}