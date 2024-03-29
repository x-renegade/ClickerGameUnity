using UnityEngine;
using System;
using R3;

public class CoinModel {
    public readonly static CoinModel Instance;
    public ReadOnlyReactiveProperty<int> OncoinChange => _onCoinChange;
    private ReactiveProperty<int> _onCoinChange =new();

    private int _coin;
    public int OneClickValue{get;private set;}

    static CoinModel() {
        Instance = new CoinModel();
    }

    private CoinModel() {
        SetCoin(GameData.Instance.Score);
        OneClickValue = GameData.Instance.OneSingleClickValue;
    }

    public void SetOneClickValue(int value, int price) {
        if (CanBuy(price)) {
            OneClickValue += Mathf.Abs(value);
            GameData.Instance.OneSingleClickValue = OneClickValue;
            RemoveCoin(price);
        }
    }

    public void SingleClickAddCoin() {
        _coin += Mathf.Abs(OneClickValue);
        LevelBarModel.Instance.TryStartNextLevel(OneClickValue);
        UpdateValue();
    }

    public void AutoClickAddCoin(int value) {
        _coin += Mathf.Abs(value);
        UpdateValue();
    }

    public void RemoveCoin(int value) {
        if (CanBuy(value)) {
            _coin -= Mathf.Abs(value);
            UpdateValue();
        }
    }

    public void UpdateValue() {
       _onCoinChange.Value = _coin;
        GameData.Instance.Score = _coin;
    }

    public bool CanBuy(int value) {
        return _coin >= value;
    }

    private void SetCoin(int value) {
        _coin += Mathf.Abs(value);
    }
}