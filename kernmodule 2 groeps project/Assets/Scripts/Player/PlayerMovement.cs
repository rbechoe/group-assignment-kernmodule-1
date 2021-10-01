using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Locomotion
{
    public void OnEnable()
    {
        EventSystem.AddListener(EventType.INPUT_FORWARD, state.OnMoveForward);
        EventSystem.AddListener(EventType.INPUT_DOWN, state.OnMoveBackward);
        EventSystem.AddListener(EventType.INPUT_LEFT, state.OnMoveLeft);
        EventSystem.AddListener(EventType.INPUT_RIGHT, state.OnMoveRight);
    }
    private void OnDisable()
    {
        EventSystem.RemoveListener(EventType.INPUT_FORWARD, state.OnMoveForward);
        EventSystem.RemoveListener(EventType.INPUT_DOWN, state.OnMoveBackward);
        EventSystem.RemoveListener(EventType.INPUT_LEFT, state.OnMoveLeft);
        EventSystem.RemoveListener(EventType.INPUT_RIGHT, state.OnMoveRight);
    }
    public void Move()
    {
        //Here the events are invoked on the player input. also play the walk animation on move.
    }
    public void SwitchStateFly()
    {
        SetState(new RunState(this));
    }
    public void SwitchStateRun()
    {
        SetState(new RunState(this));
    }
    public void SwitchStateWalk()
    {
        SetState(new WalkState(this));
    }
    private void PlayerWalkAnimation()
    {
        //play the walk animation
    }
}
