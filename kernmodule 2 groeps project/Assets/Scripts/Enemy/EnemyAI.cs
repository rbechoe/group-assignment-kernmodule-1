public class EnemyAI : IDamagable
{
    public EnemyAI()
    {
        EventSystem.AddListener(EventType.PLAYER_MOVE, SetTarget);
    }

    ~EnemyAI()
    {
        EventSystem.RemoveListener(EventType.PLAYER_MOVE, SetTarget);
    }

    public void TakeDamage(int _damage)
    {
        CheckHealth();
    }

    private void CheckHealth()
    {
        //check if enemy is not dead. if dead, call Die()
    }

    private void Die()
    {
        EventSystem<EnemyAI>.InvokeEvent(EventType.ENEMY_DEATH, this);
    }

    private void Move()
    {
        //Here the AI decides what and or how to move depending on the position of the player
    }

    private void SetTarget()
    {
        //Set the target for the AI. Nothing if player isn't close
        //Makes use of Player.Instance.playerPos
    }
}
