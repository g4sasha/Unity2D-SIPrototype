using UnityEngine;

namespace Source.Interfaces
{
	public interface IWeapon
	{
		public void Shot(Bullet.Bullet bullet, Vector2 startPosition);
	}
}