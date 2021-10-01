using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputManager inputManager;
    private WeaponManager weaponManager;

    private Locomotion locomotion;
    private PlayerMovement playerMovement;

    private List<Bullet> inactiveBullets;
    private List<Bullet> activeBullets;

    // some logic requires a setup
    private void Start()
    {
        inputManager = new InputManager(this);
        weaponManager = new WeaponManager(this);
        inactiveBullets = new List<Bullet>(500);
    }

    // keep certain logic updated
    private void Update()
    {
        inputManager.CheckInput();
        locomotion.OnUpdate();
    }

    private void OnEnable()
    {
        // set all listeners
    }

    private void OnDisable()
    {
        // remove all listeners
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