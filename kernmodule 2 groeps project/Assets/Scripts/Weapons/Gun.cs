public abstract class Gun : IWeapon
{
    public int damage;
    public int clipSize;
    public int bulletsLeft;
    public float reloadTime;
    public bool canScope;

    public Gun()
    {
        // set listeners
        EventSystem.AddListener(EventType.INPUT_SHOOT, FireWeapon);
        EventSystem.AddListener(EventType.INPUT_RELOAD, ReloadWeapon);
    }

    ~Gun()
    {
        // remove listeners
        EventSystem.RemoveListener(EventType.INPUT_SHOOT, FireWeapon);
        EventSystem.RemoveListener(EventType.INPUT_RELOAD, ReloadWeapon);
    }

    public virtual void FireWeapon()
    {
        // shoot bullet
    }

    public virtual void ReloadWeapon()
    {
        // reload weapon
    }
}