using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public void Move(Vector2 direction, float speed)
	{
		var normalizedDirection = direction.normalized;
		transform.Translate(normalizedDirection * speed * Time.deltaTime);
	}
}