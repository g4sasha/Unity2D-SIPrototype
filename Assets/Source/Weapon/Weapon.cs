using UnityEngine;

public class Gun : IWeapon
{
    public void Shot(Bullet bullet, Vector2 position)
    {
        GameObject.Instantiate(bullet, position, Quaternion.identity);
    }
}