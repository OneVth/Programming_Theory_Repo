using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    private float m_speed;
    public float speed
    {
        get { return m_speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                m_speed = value;
            }
        }
    }
    public string Color { get; protected set; }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public abstract void Move();
    public abstract void Cry();
}
