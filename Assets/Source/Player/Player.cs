using UnityEngine;

public class Player : Unit
{
	[field: SerializeField] public float Speed { get; private set; }
	[field: SerializeField] public float AttackCooldown { get; private set; }
	[field: SerializeField] public Bullet Bullet { get; private set; }
	public IMovable Movement { get; private set; }
	public IWeapon Weapon { get; private set; }

	private void Awake()
	{
		Movement = new PlayerMovement();
		Weapon = new Gun(AttackCooldown);
	}
}