using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviour : ScriptableObject
{
    public abstract void Move(ControllerInput input);

}

public static class BehaviourExtension
{
    public static void Init(this Behaviour behaviour)
    {
        Debug.Log("Initialize");
    }
}

