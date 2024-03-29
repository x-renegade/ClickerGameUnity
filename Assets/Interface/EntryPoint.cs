using UnityEngine;

public class EntryPoint : MonoBehaviour {
    [SerializeField] private GameCounterObserver _gameCounterObserver;

    private void Awake() {
        GameData.Instance.Load();
    }
}