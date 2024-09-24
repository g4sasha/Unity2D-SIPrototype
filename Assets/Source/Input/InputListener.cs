using UnityEngine;

public class InputListener : MonoBehaviour
{
	[SerializeField] private Player _player;

	private void Update()
	{
		ReadMovement();
	}

    private void ReadMovement()
    {
		var horizontal = Input.GetAxisRaw("Horizontal");
		var direction = new Vector2(horizontal, 0f);

        _player.Movement.Move(direction, _player.Speed);
    }
}