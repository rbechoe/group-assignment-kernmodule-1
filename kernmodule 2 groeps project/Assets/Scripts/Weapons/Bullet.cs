public class Bullet
{
    public float lifeTime;

    public int Damage { get; set; }

    public void SetLifeTime(float _lifeTime)
    {
        lifeTime = _lifeTime;
    }

    public void UpdateBullet()
    {
        // decrease life time and store it back into bullet pool once completely depleted
    }
}
