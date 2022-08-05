using UnityEngine;

namespace Assets
{
    [RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public class PlayerGood : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _ridigbody;
        [Header("Кол-во жизни")]
        [SerializeField] public int Health;
        [Header("Скорость")]
        [SerializeField] private Vector3 _speed;

        private float _speedX;
        private float _speedY;
        private float _movementFactor = 10f;

        private void PlayerMovement()
        {
            _ridigbody.gravityScale = 0;
            _ridigbody.velocity = _speed;
            _speedX = Input.GetAxis("Horizontal") * _movementFactor;
            _speedY = Input.GetAxis("Vertical") * _movementFactor;
            _speed = new Vector3(_speedX, _speedY, 0f);
        }

        private void Update()
        {
            PlayerMovement();
        }
    }
}

