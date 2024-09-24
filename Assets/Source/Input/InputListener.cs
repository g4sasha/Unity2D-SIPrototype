using UnityEngine;

public class InputListener : MonoBehaviour
{
	[SerializeField] private Player _player;

	private void Update()
	{
		ReadAttack();
	}

	private void FixedUpdate()
	{
		ReadMovement();
	}

    private void ReadMovement()
    {
		var horizontal = Input.GetAxisRaw("Horizontal");
		var direction = new Vector2(horizontal, 0f);

        _player.Movement.Move(_player.transform, direction, _player.Speed);
    }

	private void ReadAttack()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			_player.Weapon.Shot(_player.Bullet, _player.transform.position);
		}
	}
}