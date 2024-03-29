using UnityEngine;

public class Coinnnnnnn : MonoBehaviour {
    [SerializeField] private Vector3 vector3;
    public void DestroyCoin() {
        Destroy(gameObject);
    }

    private void Update() {
        transform.Rotate(vector3);
    }
}
