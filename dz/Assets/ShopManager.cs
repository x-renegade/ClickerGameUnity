using UnityEngine.UI;
using UnityEngine;
using R3;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private VerticalLayoutGroup _verticalLayoutGroup;
    [SerializeField] private ShopItemRoot _shopItemRoot;
    [SerializeField] private ShopItem[] _shopItems;
    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = _verticalLayoutGroup.GetComponent<RectTransform>();

        foreach (var item in _shopItems)
        {
            ShopItemRoot element = Instantiate(_shopItemRoot, _rectTransform);
            element.Init(item);
            ShopItemsObserver shopItemsObserver = new(element);
        }

        _rectTransform.sizeDelta = new Vector2(_rectTransform.rect.width, (_shopItemRoot.GetComponent<RectTransform>().rect.height + _verticalLayoutGroup.spacing) * _shopItems.Length);
    }
}
public class ShopItemsObserver
{
    public ShopItemsObserver(ShopItemRoot shopItemRoot)
    {
        CoinModel.Instance.OncoinChange.Subscribe(shopItemRoot.SetInteractable);
    }
}
