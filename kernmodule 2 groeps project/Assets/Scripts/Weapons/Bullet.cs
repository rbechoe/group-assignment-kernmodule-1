public class Bullet
{
    public int damage { get; set; }

    public float lifeTime;

    public void SetLifeTime(float _lifeTime)
    {
        lifeTime = _lifeTime;
    }

    public void UpdateBullet()
    {
        // decrease life time and store it back into bullet pool once completely depleted
    }
}