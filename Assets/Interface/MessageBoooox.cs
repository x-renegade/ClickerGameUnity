using UnityEngine;
using TMPro;

public class MessageBoooox : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _boxTextUI;

    public static MessageBoooox Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }
        gameObject.SetActive(false);
    }

    public void SetText(string text) {
        _boxTextUI.text = text;
    }
}
