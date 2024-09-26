using UnityEngine;

namespace Source.Enemy
{
	[CreateAssetMenu(fileName = "NewSpawnerConfiguration", menuName = "Spawner/New")]
	public class EnemySpawnerConfig : ScriptableObject
	{
		[field: SerializeField] public Enemy Prefab { get; private set; }
		[field: SerializeField] public float SpawnDistanceInterval { get; private set; }
		[field: SerializeField] public float WaveStepSpeed { get; private set; }
		[field: SerializeField] public int SpawnIntervalMs { get; private set; }
		[field: SerializeField] public int SpawnCount { get; private set; }
		[field: SerializeField] public int WavesCount { get; private set; }
	}
}