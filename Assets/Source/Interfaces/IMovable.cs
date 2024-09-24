using UnityEngine;

public interface IMovable
{
	public void Move(Transform transform, Vector2 direction, float speed);
}