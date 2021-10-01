public class AssaultRifle : Gun
{
    private WeaponManager weaponManager;

    // create weapon with all related data
    public AssaultRifle(WeaponManager _weaponManager, int _damage, float _reloadTime, int _clipSize)
    {
        weaponManager = _weaponManager;
        Damage = _damage;
        ReloadTime = _reloadTime;
        ClipSize = _clipSize;
        BulletsLeft = _clipSize;
        CanScope = true;
    }
}