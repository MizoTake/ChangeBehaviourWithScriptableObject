using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{

    [SerializeField]
    private Rigidbody _rigid;
    [SerializeField]
    private Behaviour _behaviour;

    public Rigidbody Rigid { get { return _rigid; } }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _behaviour.Move(this);
        }
    }
}
