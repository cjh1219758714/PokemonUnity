using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonListener : MonoBehaviour{

    public enum Direction
    {
        Null,
        Up,
        Down,
        Left,
        Right,
    }

    public enum Choose
    {
        Null,
        X,
        Y,
        A,
        B,
    }

    public Direction direction;
    public Choose choose;

    // Use this for initialization
    void Start () {
        direction = Direction.Null;
        choose = Choose.Null;
	}
	

  
}
