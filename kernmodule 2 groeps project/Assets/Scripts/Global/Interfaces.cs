public interface IDamagable
{
    void TakeDamage(int _damage);
}

public interface IWeapon
{
    void FireWeapon();
    void ReloadWeapon();
}