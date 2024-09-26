using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Unit
{
	public event Action<int> OnHealthChanged;
	public static Player Instance { get; private set; }
	[field: SerializeField] public float Speed { get; private set; }
	[field: SerializeField] public float AttackCooldown { get; private set; }
	[field: SerializeField] public Bullet Bullet { get; private set; }
	public IMovable Movement { get; private set; }
	public IWeapon Weapon { get; private set; }

	private void Awake()
	{
		if (Instance)
		{
			Destroy(gameObject);
			return;
		}
		else
		{
			Instance = this;
		}

		Instance = this;
		Movement = new PlayerMovement();
		Weapon = new Gun(AttackCooldown);
	}

	private void OnDestroy()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public override void ApplyDamage(int damage)
	{
		base.ApplyDamage(damage);
		OnHealthChanged?.Invoke(Health);
	}
}