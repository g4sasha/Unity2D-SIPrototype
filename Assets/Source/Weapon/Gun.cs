using Cysharp.Threading.Tasks;
using UnityEngine;
using Source.Interfaces;

namespace Source.Weapon
{
    public class Gun : IWeapon
    {
        public float Cooldown { get; private set; }
        public bool IsReloading { get; private set; }

        public Gun(float cooldown)
        {
            Cooldown = cooldown;
        }

        public void Shot(Bullet.Bullet bullet, Vector2 position)
        {
            if (IsReloading)
            {
                return;
            }

            ApplyShot(bullet, position).Forget();
        }

        public async UniTaskVoid ApplyShot(Bullet.Bullet bullet, Vector2 position)
        {
            IsReloading = true;
            GameObject.Instantiate(bullet, position, Quaternion.identity);
            await UniTask.Delay((int)(Cooldown * 1000f));
            IsReloading = false;
        }
    }
}