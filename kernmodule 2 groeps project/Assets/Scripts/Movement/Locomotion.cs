using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : StateMachine
{
    private PlayerMovement playerMovement;

    public void OnUpdate()
    {
        playerMovement.Move();
    }

}
