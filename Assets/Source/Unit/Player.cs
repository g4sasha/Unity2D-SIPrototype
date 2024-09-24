using UnityEngine;

public class Player : Unit
{
	[field: SerializeField] public float Speed { get; private set; }
	[field: SerializeField] public PlayerMovement Movement { get; private set; }
}