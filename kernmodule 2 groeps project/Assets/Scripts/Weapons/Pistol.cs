public class Pistol : Gun
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
}