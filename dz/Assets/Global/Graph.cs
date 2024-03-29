using UnityEngine;

public class Graph : MonoBehaviour {
    [SerializeField] private AnimationCurve _animationCurve;
    [SerializeField] private Mode _mode;


    private void Update() {
        Keyframe keyframe;
        switch (_mode) {
            case Mode.Rotate:
                keyframe = new Keyframe(Time.time, transform.eulerAngles.y, 0, 0, 0, 0);
                _animationCurve.AddKey(keyframe);
                break;
            case Mode.Position:
                keyframe = new Keyframe(Time.time, transform.position.z, 0, 0, 0, 0);
                _animationCurve.AddKey(keyframe);
                break;
        }
    }

    public enum Mode {
        Rotate,
        Position,
    }
}
