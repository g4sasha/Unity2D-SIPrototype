using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.Input
{
	public class InputListener : MonoBehaviour
	{
		[SerializeField] private Player.Player _player;

		private void Update()
		{
			ReadAttack();
			ReadRestart();
		}

		private void FixedUpdate()
		{
			ReadMovement();
		}

		private void ReadRestart()
		{
			if (UnityEngine.Input.GetKeyDown(KeyCode.R))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}

		private void ReadMovement()
		{
			var horizontal = UnityEngine.Input.GetAxisRaw("Horizontal");
			var direction = new Vector2(horizontal, 0f);

			_player.Movement.Move(_player.transform, direction, _player.Speed);
		}

		private void ReadAttack()
		{
			if (UnityEngine.Input.GetButton("Fire1"))
			{
				_player.Weapon.Shot(_player.Bullet, _player.transform.position);
			}
		}
	}
}