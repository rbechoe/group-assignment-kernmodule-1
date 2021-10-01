using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected PlayerMovement playerMovement;
    public float speed;

    public State(PlayerMovement _playerMovement)
    {
        playerMovement = _playerMovement;
    }
    public virtual void OnMoveForward()
    {
        //move forward
    }
    public virtual void OnMoveBackward()
    {
        //move backward
    }
    public virtual void OnMoveLeft()
    {
        //move left
    }
    public virtual void OnMoveRight()
    {
        //move right
    }
    public virtual void OnEnter()
    {
        //when enabled do this
    }
    public virtual void OnExit()
    {
        //when dissabled do this
    }


}
