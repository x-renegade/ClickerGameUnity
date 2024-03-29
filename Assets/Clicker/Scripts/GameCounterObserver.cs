using UnityEngine;
using R3;

public class GameCounterObserver : MonoBehaviour {
    [SerializeField] private GameCounterRoot counterRoot;
    [SerializeField] private AutoClickLevelModel _levelModel;

    public void Start() {
        _levelModel.OneCLickValue.Subscribe(counterRoot.UpdateAutoClick);
        CoinModel.Instance.OncoinChange.Subscribe(UpdateCoin);

        CoinModel.Instance.UpdateValue();
    }

    private void UpdateCoin(int value) {
        counterRoot.SetMonkeyCounterText(value.ToString());
    }

}