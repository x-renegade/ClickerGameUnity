using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class ToggleScript : MonoBehaviour {
    [SerializeField] Image _imageBackground;
    [SerializeField] Toggle _toggle;

    private void Start() {
        _toggle.onValueChanged.AddListener(ToggleMethod);
    }

    private void ToggleMethod(bool toggleState) {
        if (toggleState) {
            print("\a");
            _imageBackground.color = Color.red;
        }
        else {
            _imageBackground.color = Color.green;
        }
    }
}
