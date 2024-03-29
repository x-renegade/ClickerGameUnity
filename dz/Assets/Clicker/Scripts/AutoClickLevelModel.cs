using System.Collections;
using UnityEngine;
using R3;

public class AutoClickLevelModel : MonoBehaviour {
    public ReadOnlyReactiveProperty<int> OneCLickValue => _oneCLickValue;
    private ReactiveProperty<int> _oneCLickValue = new();

    private IEnumerator Start() {
        _oneCLickValue.Value = GameData.Instance.OneAutoClickValue;

        while (true) {
            yield return new WaitForSeconds(1);
            CoinModel.Instance.AutoClickAddCoin(_oneCLickValue.Value);
        }
    }

    public bool TryUpgradeClickValue(int upgradeValue, int price) {
        bool result = false;

        if (CoinModel.Instance.CanBuy(price)) {
            _oneCLickValue.Value += upgradeValue;
            CoinModel.Instance.RemoveCoin(price);
            GameData.Instance.OneAutoClickValue = _oneCLickValue.Value;
            result = true;
        }

        return result;
    }
}