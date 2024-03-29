using UnityEngine.UI;
using UnityEngine;

public class SliderController : MonoBehaviour {
    [SerializeField] private Slider _smallSizeSlider;
    [SerializeField] private Slider _averageSizeSlider;
    [SerializeField] private Slider _bigSizeSlider;

    [SerializeField] private Transform _smallBallTransform;
    [SerializeField] private Transform _averageBallTransform;
    [SerializeField] private Transform _bigBallTransform;

    private float _smallStartSize;
    private float _averageStartSize;
    private float _bigStartSize;

    private void Start() {
        _smallStartSize = _smallBallTransform.localScale.x;
        _averageStartSize = _averageBallTransform.localScale.x;
        _bigStartSize = _bigBallTransform.localScale.x;

        _smallSizeSlider.onValueChanged.AddListener(UpdateSmallSlider);
        _averageSizeSlider.onValueChanged.AddListener(UpdateAverageSlider);
        _bigSizeSlider.onValueChanged.AddListener(UpdateBigSlider);
    }

    private void UpdateSmallSlider(float value) {
        _smallBallTransform.transform.localScale = new Vector3(_smallStartSize * value, _smallStartSize * value, _smallStartSize * value);
    }

    private void UpdateAverageSlider(float value) {
        _averageBallTransform.transform.localScale = new Vector3(_averageStartSize * value, _averageStartSize * value, _averageStartSize * value);
    }

    private void UpdateBigSlider(float value) {
        _bigBallTransform.transform.localScale = new Vector3(_bigStartSize * value, _bigStartSize * value, _bigStartSize * value);
    }
}
