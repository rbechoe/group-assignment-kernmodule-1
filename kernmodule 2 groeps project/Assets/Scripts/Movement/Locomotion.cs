public class Locomotion : StateMachine
{
    private PlayerMovement playerMovement;

    public void OnUpdate()
    {
        playerMovement.Move();
    }
}
