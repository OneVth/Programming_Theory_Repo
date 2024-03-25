using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    [SerializeField] float inputSpeed = 1.0f;

    void Awake()
    {
        SetSpeed(inputSpeed);
    }
    public override void Cry()
    {
        Debug.Log("Meow");
    }

    public override void Move()
    {
        Debug.Log("The cat moves with a speed of " + speed);
    }
}

