using System.Threading;
using UnityEngine;

public class Mover : MonoBehaviour {
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speedMove = 0.5f;
    [SerializeField] private float _jumpForce = 0.5f;
    [SerializeField] private float _jumpNormal = 0.5f;
    private float _horizontal;
    private float _vertical;
    private float _mouseX;
    private bool _isJump;

    void Update() {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        _mouseX = Input.GetAxis("Mouse X");

        if (Input.GetKeyDown(KeyCode.Space) && !_isJump) {
            Jump();
            _isJump = true;
        }
    }

    private void FixedUpdate() {
        Vector3 offset = new Vector3(_horizontal * _speedMove, _rigidbody.velocity.y, _vertical * _speedMove);
        Vector3 localOffset = transform.TransformVector(offset);
        _rigidbody.velocity = localOffset;
        Vector3 rotation = new Vector3(0, _mouseX, 0);
        transform.Rotate(rotation);
    }

    private void Jump() {
        _rigidbody.AddRelativeForce(new Vector3(0, _jumpForce, 0), ForceMode.VelocityChange);
    }

    private void OnCollisionExit(Collision collision) {
        _isJump = true;
    }

    private void OnCollisionStay(Collision collision) {
        if (_isJump) {
            if (collision.contacts[0].normal.y > _jumpNormal) {
                _isJump = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent(out Coinnnnnnn coin)) {
            coin.DestroyCoin();
        }
    }
}
