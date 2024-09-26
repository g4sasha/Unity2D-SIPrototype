using UnityEngine;
using Source.Interfaces;

namespace Source.Player
{
	public class PlayerMovement : IMovable
	{
		public void Move(Transform transform, Vector2 direction, float speed)
		{
			var normalizedDirection = direction.normalized;
			transform.Translate(normalizedDirection * speed * Time.fixedDeltaTime);
		}
	}
}