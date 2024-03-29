using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ShopItemRoot : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _downDescriptionUI;
    [SerializeField] private TextMeshProUGUI _upDescriptionUI;
    [SerializeField] private TextMeshProUGUI _priceUI;
    [SerializeField] private AudioSource _buttonClick;
    [SerializeField] private Button _button;

    private AutoClickLevelModel _autoClickLevelModel;
    private UpgradeType _upgradeType;
    private ShopItem _shopItem;

    private void Start() {
        _autoClickLevelModel = FindObjectOfType<AutoClickLevelModel>();
        _button.onClick.AddListener(UpgradeItem);
    }

    private void UpgradeItem() {
        _buttonClick.PlayOneShot(_buttonClick.clip);
        switch (_upgradeType) {
            case UpgradeType.Automatic:
                _autoClickLevelModel.TryUpgradeClickValue(_shopItem.UpgradeValue, _shopItem.Price);
                break;
            case UpgradeType.SingleClick:
                CoinModel.Instance.SetOneClickValue(_shopItem.UpgradeValue, _shopItem.Price);
                break;
        }
    }

    public void Init(ShopItem shopItem) {
        _shopItem = shopItem;
        _downDescriptionUI.text = _shopItem.GetDescription();
        _upDescriptionUI.text = _shopItem.UpDescriptionUI;
        _priceUI.text = _shopItem.Price.ToString();
        _upgradeType = shopItem.UpgradeType;
    }
    public void SetInteractable(int moneyValue)
    {
        _button.interactable=moneyValue>=_shopItem.Price;
    }
}

public enum UpgradeType {
    Automatic,
    SingleClick
}