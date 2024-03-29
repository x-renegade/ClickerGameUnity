using UnityEngine.UI;
using UnityEngine;

public class ButtonSettings : MonoBehaviour {
    [SerializeField] private Button _buttonSettings;
    [SerializeField] private Transform _settingsPanel;

    private void Start() {
        _buttonSettings.onClick.AddListener(SettingsClick);
    }
     
    private void SettingsClick() {
        MessageBoooox.Instance.gameObject.SetActive(true);
        MessageBoooox.Instance.SetText("Привет!");
    }

    private void OnDisable() {
        _buttonSettings.onClick.RemoveAllListeners();
    }
}
