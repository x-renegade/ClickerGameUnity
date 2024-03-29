using UnityEngine;
using R3;
using Assets.Clicker.Scripts;

public class LevelBarObserver : MonoBehaviour {
    [SerializeField] private MainImage _mainImage;
    [SerializeField] private LevelBarRoot _barRoot;
    [SerializeField] private Level[] _levels;
    [SerializeField] private PrefabForDz _prefabForDz;

    private void Start() {
        LevelBarModel.Instance.BarValue.Subscribe(_barRoot.FillChanged);
        LevelBarModel.Instance.CurentLevel.Subscribe(_barRoot.LevelUpdate);
        LevelBarModel.Instance.LevelImageUpdate.Subscribe(_mainImage.UpdateMainImage);
        LevelBarModel.Instance.PlaySound += _barRoot.PlayNewLevel;
        LevelBarModel.Instance.Init(_levels);


        Instantiate(_prefabForDz);
        Instantiate(_prefabForDz);
        Instantiate(_prefabForDz);
        Instantiate(_prefabForDz);
    }
}
