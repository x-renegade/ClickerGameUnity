using UnityEngine.UI;
using UnityEngine;

public class CloseButton : MonoBehaviour {
    [SerializeField] private Button _closeButton;

    private void OnEnable() {
        _closeButton.onClick.AddListener(ButtonClick);
    }

    public void ButtonClick() {
        MessageBoooox.Instance.gameObject.SetActive(false);
    }

    private void OnDisable() {
        _closeButton.onClick.RemoveAllListeners();
    }
}
