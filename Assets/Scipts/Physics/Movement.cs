using UnityEngine;

namespace TrellOfDarkness.Physics.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Rigidbody2D _rigibody;

        private void Awake()
        {
            _rigibody = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 direction)
        {
            _rigibody.velocity = direction * _speed;
        }
    }
}