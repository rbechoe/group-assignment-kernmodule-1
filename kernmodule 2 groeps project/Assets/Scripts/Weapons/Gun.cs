public abstract class Gun : IWeapon
{
    public int Damage;
    public int ClipSize;
    public int BulletsLeft;
    public float ReloadTime;
    public bool CanScope;

    protected virtual void OnEnable()
    {
        // set listeners
        EventSystem.AddListener(EventType.INPUT_SHOOT, FireWeapon);
        EventSystem.AddListener(EventType.INPUT_RELOAD, ReloadWeapon);
    }

    protected virtual void OnDisable()
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