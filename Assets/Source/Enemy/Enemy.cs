using System.Collections.Generic;
using UnityEngine;
using Source.Interfaces;

namespace Source.Enemy
{
	public abstract class Enemy : Unit.Unit
	{
		[field: SerializeField] public float StepLength { get; private set; }
		[field: SerializeField] public int DropScore { get; private set; }
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

			if (transform.position.y < -4f)
			{
				Destroy(gameObject);
				Player.Player.Instance.ApplyDamage(1);
			}
		}
	}
}