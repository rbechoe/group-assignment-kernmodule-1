public class Pistol : Gun
{
    private WeaponManager weaponManager;

    // create weapon with all related data
    public Pistol(WeaponManager _weaponManager, int _damage, float _reloadTime, int _clipSize)
    {
        weaponManager = _weaponManager;
        damage = _damage;
        reloadTime = _reloadTime;
        clipSize = _clipSize;
        bulletsLeft = _clipSize;
        canScope = false;
    }
}
