using UnityEngine;
using TMPro;

public class GameCounterRoot : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _monkeyPerSecondCounter;
    [SerializeField] private TextMeshProUGUI _monkeyCounter;
    [SerializeField] private TextMeshProUGUI _autoClicText;

    public void UpdateAutoClick(int value) {
        _autoClicText.text = value.ToString();
    }

    public void SetMonkeyCounterText(string value) {
        _monkeyCounter.text = value;
    }

    public void SetMonkerPerSecondText(string value) {
        _monkeyPerSecondCounter.text = value;
    }
}
