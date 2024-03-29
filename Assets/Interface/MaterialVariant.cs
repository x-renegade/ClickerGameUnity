using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Toggle))]
public class MaterialVariant : MonoBehaviour {
    [SerializeField] private Material _material;
    private MeshRenderer _meshRenderer;
    private Toggle _toggle;

    public void Init(MeshRenderer meshRenderer) {
        _meshRenderer = meshRenderer;
        _toggle = GetComponent<Toggle>();
        _toggle.onValueChanged.AddListener(ChangeMaterial);
    }

    private void ChangeMaterial(bool arg0) {
        if (arg0) {
            _meshRenderer.material = _material;
        }
    }
}