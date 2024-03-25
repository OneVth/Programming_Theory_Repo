using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [SerializeField] private float inputSpeed;
    private void Awake()
    {
        SetSpeed(inputSpeed);
    }

    public override void Move()
    {
        Debug.Log("The dog moves with a speed of " + speed);
    }
    public override void Cry()
    {
        Debug.Log("bark");
    }
}
