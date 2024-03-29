using UnityEngine;

//[ExecuteAlways]
public class LerpExample_1 : MonoBehaviour {
    [SerializeField] private Transform _start;
    [SerializeField] private Transform _end;
    private float _time;
    [SerializeField] private Transform _targetPosition;
    private bool _isPresedP;

    private void Start() {
        Debug.Log("");
        Debug.LogWarning("");
        Debug.LogError("");
    }
}