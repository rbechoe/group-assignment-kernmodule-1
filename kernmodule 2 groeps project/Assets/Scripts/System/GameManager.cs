using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputManager inputManager;
    private WeaponManager weaponManager;

    private Locomotion locomotion;
    private PlayerMovement playerMovement;

    private EnemyManager enemyManager;

    private List<Bullet> inactiveBullets;
    private List<Bullet> activeBullets;

    // some logic requires a setup
    private void Start()
    {
        inputManager = new InputManager(this);
        weaponManager = new WeaponManager(this);

        enemyManager = new EnemyManager(this);

        inactiveBullets = new List<Bullet>(500);
    }

    // keep certain logic updated
    private void Update()
    {
        inputManager.CheckInput();
        locomotion.OnUpdate();
        enemyManager.OnUpdate();
    }

    // get an inactive bullet from the list to use
    public Bullet GetBullet()
    {
        Bullet bullet = null;

        if (inactiveBullets.Count > 0)
        {
            bullet = inactiveBullets[0];
            activeBullets.Add(bullet);
            inactiveBullets.Remove(bullet);
        }

        return bullet;
    }

    //  recycle bullet through object pooling
    public void ReturnBullet(Bullet _bullet)
    {
        activeBullets.Remove(_bullet);
        inactiveBullets.Add(_bullet);
    }
}
