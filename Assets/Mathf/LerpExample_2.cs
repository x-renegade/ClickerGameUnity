using UnityEngine;

[ExecuteAlways]
public class LerpExample_2 : MonoBehaviour {
    [SerializeField] private Transform _startTransform;
    [SerializeField] private Transform _endTransform;
    [SerializeField, Range(0, 1)] private float _time;

    private void Update() {
        transform.position = Vector3.Lerp(_startTransform.position, _endTransform.position, _time);
        transform.rotation = Quaternion.Lerp(_startTransform.rotation, _endTransform.rotation, _time);
    }
}
