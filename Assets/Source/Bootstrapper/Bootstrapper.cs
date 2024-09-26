using Source.Enemy;
using UnityEngine;

namespace Source.Bootstrapper
{
	public class Bootstrapper : MonoBehaviour
	{
		[SerializeField] private EnemySpawnerConfig _enemySpawnerConfig;
		private EnemyMover _enemyMover;

		private void Awake()
		{
			_enemyMover = new EnemyMover(Enemy.Enemy.Enemies, _enemySpawnerConfig);
		}

		private void Start()
		{
			_enemyMover.MoveCycle().Forget();
		}

		private void Update()
		{
			_enemyMover.Enemies = Enemy.Enemy.Enemies;
		}
	}
}