using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeText : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private int _duration = 2;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField] private int _upValue = 2;

    private void Start()
    {
        var cam = Camera.main;
        _canvas.worldCamera = cam;
        _textMeshProUGUI.text = CoinModel.Instance.OneClickValue.ToString();
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
        transform.DOMoveY(transform.position.y + _upValue, _duration);
        _canvasGroup.DOFade(0, _duration).OnComplete(() => { Destroy(gameObject); });
    }
}
