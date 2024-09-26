using UnityEngine;

public class EnemyMovement : IMovable
{
	public void Move(Transform transform, Vector2 direction, float stepLength)
	{
		var normalizedDirection = direction.normalized;
		transform.Translate(normalizedDirection * stepLength);
	}
}