using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class Engine
{
    [HideInInspector] public float speed;
    public float maxSpeed;
    public float brakeMultiplier;
    public float accelerationMultiplier;
    public float boostMultiplier;
    public void Initialize(Initializer initializer, Vehicle car)
    {
    
    }

    public void Accelerate()
    {
        Debug.Log("go");
    }
    
    public void Brake()
    {
        
    }

    public void Boost()
    {
        
    }
}
