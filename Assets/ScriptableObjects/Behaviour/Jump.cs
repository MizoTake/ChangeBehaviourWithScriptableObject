using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Behaviour
{

    public int Power;

    public override void Move(ControllerInput input)
    {
        this.Init();
        input.Rigid.AddForce(Vector3.up * Power, ForceMode.Impulse);
    }
}
