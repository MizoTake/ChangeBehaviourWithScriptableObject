using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : Behaviour
{

    public Material Target;

    public override void Move(ControllerInput input)
    {
        this.Init();
        input.gameObject.GetComponent<MeshRenderer>().material = Target;
    }
}
