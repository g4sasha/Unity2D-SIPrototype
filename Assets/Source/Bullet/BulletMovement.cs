using UnityEngine;
using Source.Interfaces;

namespace Source.Bullet
{
	public class BulletMovement : IMovable
	{
		public void Move(Transform transform, Vector2 direction, float speed)
		{
			var normalizedDirection = direction.normalized;
			transform.Translate(normalizedDirection * speed * Time.fixedDeltaTime);
		}
	}
}