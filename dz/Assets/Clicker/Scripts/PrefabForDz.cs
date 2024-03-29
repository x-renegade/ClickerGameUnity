using DG.Tweening;
using System;
using System.Collections.Generic;

using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Clicker.Scripts
{
    public class PrefabForDz:MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        private void Start()
        {
            _canvasGroup.DOFade(0, 3).OnComplete(() => { Destroy(gameObject); });
        }
    }
}
