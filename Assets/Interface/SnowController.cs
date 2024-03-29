using System.Collections.Generic;
using UnityEngine;

public class SnowController : MonoBehaviour {
    [SerializeField] private List<MaterialVariant> _materialVariants;
    [SerializeField] private MeshRenderer _floorMaterial;

    private void Start() {
        foreach (var item in _materialVariants) {
            item.Init(_floorMaterial);
        }
    }
}
