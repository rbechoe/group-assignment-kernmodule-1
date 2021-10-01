public class RunState : State
{
    public RunState(PlayerMovement _playerMovement) : base(_playerMovement)
    {
        playerMovement = _playerMovement;
    }

    public override void OnMoveForward()
    {
        //move forward
    }

    public override void OnMoveBackward()
    {
        //move backward
    }

    public override void OnMoveLeft()
    {
        //move left
    }

    public override void OnMoveRight()
    {
        //move right
    }

    public override void OnEnter()
    {
        //is called when you enter the state
        speed = 10;
    }

    public override void OnExit()
    {
        //is called when you exit the state
    }
}
