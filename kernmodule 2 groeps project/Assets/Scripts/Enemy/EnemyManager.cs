using System.Collections.Generic;

public class EnemyManager
{
    public float spawnTime;

    private GameManager gameManager;

    private List<EnemyAI> inactiveEnemies;
    private List<EnemyAI> activeEnemies;

    public EnemyManager(GameManager _gameManager)
    {
        gameManager = _gameManager;
        inactiveEnemies = new List<EnemyAI>(500);

        EventSystem<EnemyAI>.AddListener(EventType.ENEMY_DEATH, ReturnEnemy);
    }

    ~EnemyManager()
    {
        EventSystem<EnemyAI>.RemoveListener(EventType.ENEMY_DEATH, ReturnEnemy);
    }

    public void OnUpdate()
    {
        //spawn enemy if time is zero, then call SetSpawnTime(x)
    }

    // get an inactive enemy from the list to use
    public EnemyAI GetEnemy()
    {
        EnemyAI enemy = null;

        if (inactiveEnemies.Count > 0)
        {
            enemy = inactiveEnemies[0];
            activeEnemies.Add(enemy);
            inactiveEnemies.Remove(enemy);
        }

        return enemy;
    }

    // recycle enemy through object pooling
    public void ReturnEnemy(EnemyAI _enemy)
    {
        activeEnemies.Remove(_enemy);
        inactiveEnemies.Add(_enemy);
    }

    private void SetSpawnTime(float _spawnTime)
    {
        spawnTime = _spawnTime;
    }
}
