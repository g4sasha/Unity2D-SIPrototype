using UnityEngine;
using Source.Interfaces;

namespace Source.Bullet
{
    public class Bullet : MonoBehaviour
    {
        public IMovable Movement { get; private set; }
        [SerializeField] private LayerMask _enemyLayer;
        [SerializeField] private float _bulletSpeed;
        [SerializeField] private int _damage;
        private Camera _camera;

        private void Awake()
        {
            Movement = new BulletMovement();
            _camera = Camera.main;
        }

        private void Update()
        {
            if (!IsVisibleFrom(_camera))
            {
                Destroy(gameObject);
            }
        }

        private void FixedUpdate()
        {
            Movement.Move(transform, Vector2.up, _bulletSpeed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if ((_enemyLayer & 1 << other.gameObject.layer) != 0)
            {
                var enemy = other.gameObject.GetComponent<Unit.Unit>();
                enemy.ApplyDamage(_damage);
                Destroy(gameObject);
            }
        }

        private bool IsVisibleFrom(Camera cam)
        {
            Vector3 screenPoint = cam.WorldToViewportPoint(transform.position);
            return screenPoint.x >= 0 && screenPoint.x <= 1 && screenPoint.y >= 0 && screenPoint.y <= 1;
        }
    }
}