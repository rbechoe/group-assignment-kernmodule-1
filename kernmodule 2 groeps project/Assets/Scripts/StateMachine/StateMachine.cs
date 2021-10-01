using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    protected State state;

    public void SetState(State _state)
    {
        //set the state that is currently active$
        state = _state;
    }
}
