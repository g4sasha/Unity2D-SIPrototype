using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Source.Enemy
{
	public class EnemyMover
	{
		public List<Enemy> Enemies { get; set; }
		private EnemySpawnerConfig _config;

		public EnemyMover(List<Enemy> enemies, EnemySpawnerConfig config)
		{
			Enemies = enemies;
			_config = config;
		}

		public async UniTaskVoid MoveCycle()
		{
			while (Player.Player.Instance.Health > 0)
			{
				await UniTask.Delay((int)(_config.WaveStepSpeed * 1000f));

				foreach (var enemy in Enemies)
				{
					enemy.Step();
				}
			}
		}
	}
}