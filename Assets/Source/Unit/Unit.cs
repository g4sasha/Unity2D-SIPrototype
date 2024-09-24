using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [field: SerializeField] public int Health { get; protected set; }

    public virtual void ApplyDamage(int damage)
    {
        if (damage < 0)
        {
            throw new System.ArgumentException("Damage cannot be negative");
        }

        Health -= damage;

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}