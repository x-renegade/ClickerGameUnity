using UnityEngine;

[ExecuteAlways]
public class LerpExample_3 : MonoBehaviour {
    [SerializeField] private Transform _endTransform;
    [SerializeField] private AnimationCurve _curve;
    [SerializeField, Range(0, 1)] private float _time;
    private Vector3 _startPosition;

    private void Start() {
        _startPosition = transform.position;
    }

    private void Update() {
        float curveValue = _curve.Evaluate(_time);
        transform.position = Vector3.Lerp(_startPosition, new Vector3(_endTransform.position.x, _endTransform.position.y + curveValue, _endTransform.position.z), _time);
    }
}