using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Slider))]
public class SlideScript : MonoBehaviour {
    private Slider _slider;
    private Light _light;

    private void Start() {
        _slider = GetComponent<Slider>();
        _light = FindObjectOfType<Light>();

        _slider.value = _light.intensity;
        _slider.onValueChanged.AddListener(ChangeNewValue);
    }

    private void ChangeNewValue(float newValue) {
        _light.intensity = newValue;
    }
}