using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
	[SerializeField] private EnemySpawnerConfig _enemySpawnerConfig;
	private EnemyMover _enemyMover;

	private void Awake()
	{
		_enemyMover = new EnemyMover(Enemy.Enemies, _enemySpawnerConfig);
	}

	private void Start()
	{
		_enemyMover.MoveCycle().Forget();
	}

	private void Update()
	{
		_enemyMover.Enemies = Enemy.Enemies;
	}
}