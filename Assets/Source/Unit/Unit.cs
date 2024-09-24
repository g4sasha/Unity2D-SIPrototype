using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [field: SerializeField] public float health { get; protected set; }

    public virtual void ApplyDamage(float damage)
    {
        if (damage < 0)
        {
            throw new System.ArgumentException("Damage cannot be negative");
        }

        health -= damage;
    }
}