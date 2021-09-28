public class Pistol : Gun, IWeapon
{
    private WeaponManager weaponManager;

    // create weapon with all related data
    public Pistol(WeaponManager _weaponManager, int _damage, float _reloadTime, int _clipSize)
    {
        weaponManager = _weaponManager;
        Damage = _damage;
        ReloadTime = _reloadTime;
        ClipSize = _clipSize;
        BulletsLeft = _clipSize;
        CanScope = false;
    }

    private void OnEnable()
    {
        // set listeners
        EventSystem.AddListener(EventType.INPUT_SHOOT, FireWeapon);
        EventSystem.AddListener(EventType.INPUT_RELOAD, ReloadWeapon);
    }

    private void OnDisable()
    {
        // remove listeners
        EventSystem.RemoveListener(EventType.INPUT_SHOOT, FireWeapon);
        EventSystem.RemoveListener(EventType.INPUT_RELOAD, ReloadWeapon);
    }

    public void FireWeapon()
    {
        // shoot bullet
    }

    public void ReloadWeapon()
    {
        // reload weapon
    }
}