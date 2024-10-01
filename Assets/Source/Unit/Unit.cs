using System;
using UnityEngine;

namespace Source.Unit
{
    public abstract class Unit : MonoBehaviour
    {
        [field: SerializeField] public int Health { get; protected set; }
        public event Action OnDied;

        public virtual void ApplyDamage(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException("Damage cannot be negative");
            }

            Health -= damage;

            if (Health <= 0)
            {
                OnDied?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}