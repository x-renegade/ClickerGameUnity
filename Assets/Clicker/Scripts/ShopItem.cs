using UnityEngine;

[CreateAssetMenu(fileName = "ShopItem", menuName = "ShopItem", order = 0)]
public class ShopItem : ScriptableObject {
    [field: SerializeField] public UpgradeType UpgradeType { get; private set; }
    [field: SerializeField] public int UpgradeValue { get; private set; }
    [field: SerializeField] public int Price { get; private set; }
    [field: SerializeField] public string UpDescriptionUI { get; private set; }
    [field: SerializeField] private string _downDescriptionUI;

    public string GetDescription() {
        return string.Format(_downDescriptionUI, UpgradeValue);
    }
}
