using UnityEngine.UI;
using UnityEngine;

public class FillAnimation : MonoBehaviour {
    [SerializeField] private Image _image;
    private float _time = 0;
    int colorValue = 255;

    private void Update() {
        _image.color = new Color(_time * colorValue, _time * colorValue, _time * colorValue);
        _time += Time.deltaTime / 100;
    }

    public void ButtonClick() {
        Debug.Log("Ты нажал на кнопку!!!");
    }
}
