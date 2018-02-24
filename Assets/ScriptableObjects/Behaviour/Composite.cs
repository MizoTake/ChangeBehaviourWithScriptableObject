using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : Behaviour
{

    public Behaviour[] Behaviours;

    public override void Move(ControllerInput input)
    {
        this.Init();
        foreach (var behaviour in Behaviours)
        {
            behaviour.Move(input);
        }
    }
}