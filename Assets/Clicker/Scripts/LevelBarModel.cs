using UnityEngine;
using R3;
using System;

public class LevelBarModel {
    #region Singletone
    public readonly static LevelBarModel Instance;
    static LevelBarModel() {
        Instance = new LevelBarModel();
    }
    private LevelBarModel() {
    }
    #endregion

    public Level _currentLevel => _levels[_currentLevelIndex.Value];
    public ReadOnlyReactiveProperty<Score> BarValue => _barValue;
    private ReactiveProperty<Score> _barValue = new();
    public ReadOnlyReactiveProperty<int> CurentLevel => _currentLevelIndex;
    private ReactiveProperty<int> _currentLevelIndex = new();
    public ReadOnlyReactiveProperty<Sprite> LevelImageUpdate => _levelImageUpdate;
    private ReactiveProperty<Sprite> _levelImageUpdate = new();

    private Level[] _levels;
    public Action PlaySound;

    public Action PrefabForDz;
    public void Init(Level[] levels) {
        _levels = levels;
        _barValue.Value = GameData.Instance.LevelValue == null ? new Score(0, _levels[_currentLevelIndex.Value].LevelScore, 0) : GameData.Instance.LevelValue;
        _currentLevelIndex.Value = (GameData.Instance.Level);
        _levelImageUpdate.Value = _levels[_currentLevelIndex.Value].LevelImage;
    }

    public void TryStartNextLevel(float value) {
        if (_barValue.Value.CanStartNextLevel(Mathf.Abs(value))) {
            _currentLevelIndex.Value++;
            _currentLevelIndex.Value = Mathf.Clamp(_currentLevelIndex.Value, 0, _levels.Length - 1);
            _barValue.Value.NextLevel(_levels[_currentLevelIndex.Value].LevelScore);
            GameData.Instance.Level = _currentLevelIndex.Value;
            _levelImageUpdate.Value = _levels[_currentLevelIndex.Value].LevelImage;
            PlaySound?.Invoke();
        }
        _barValue.Value = new Score(_barValue.Value.MinValue, _barValue.Value.MaxValue, _barValue.Value.CurrentValue);
        GameData.Instance.LevelValue = _barValue.Value;
    }
}
