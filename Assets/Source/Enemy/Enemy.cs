using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Unit
{
	[field: SerializeField] public float StepLength { get; private set; }
	public IMovable Movement { get; private set; }
	public static List<Enemy> Enemies { get; private set; } = new();

	private void Awake()
	{
		Movement = new EnemyMovement();
		Enemies.Add(this);
	}

	private void OnDestroy()
	{
		Enemies.Remove(this);
	}

	public void Step()
	{
		Movement.Move(transform, Vector2.down, StepLength);
	}
}