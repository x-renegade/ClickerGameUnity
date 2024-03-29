using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class AddOneButto : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _textUI;
    [SerializeField] private Button _buttonAddOne;
    private int counter = 0;

    private void Start() {
        _buttonAddOne.onClick.AddListener(AddOne);
        _textUI.text = counter.ToString();
    }

    private void AddOne() {
        counter++;
        _textUI.text = counter.ToString();
    }
}
