using UnityEngine;

public class Enemy : Unit
{
	[field: SerializeField] public float Speed { get; private set; }
	public IMovable Movement { get; private set; }

	private void Awake()
	{
		Movement = new EnemyMovement();
	}

	private void FixedUpdate()
	{
		Step();
	}

	public void Step()
	{
		Movement.Move(transform, Vector2.down, Speed);
	}
}