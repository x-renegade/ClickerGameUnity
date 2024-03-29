using UnityEngine.EventSystems;
using UnityEngine;
using DG.Tweening;
using System;
using Assets.Clicker.Scripts;

public class MainImage : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private SpriteRenderer _mainImage;
    [SerializeField] private AudioSource _mainClip;
    [SerializeField] private ParticleSystem _monkeParticle;
    [SerializeField] private Camera _camera;
    [SerializeField] private FadeText _fadeText;
    private Tween _tween;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 0, -25), 2).SetLoops(-1, LoopType.Yoyo);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.GetMouseButtonDown(0))
        {
            CoinModel.Instance.SingleClickAddCoin();
            Animation();
            PlayParticle();
            TextInstance();
            _mainClip.PlayOneShot(_mainClip.clip);
        }
    }

    public void TextInstance()
    {
        Instantiate(_fadeText);
    }
    public void PlayParticle()
    {
        var mousePos=Input.mousePosition;
        var pos = _camera.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,10));
        var element = Instantiate(_monkeParticle, pos, Quaternion.identity);
        Destroy(element.gameObject,2f);
    }

    public void UpdateMainImage(Sprite sprite)
    {
        _mainImage.sprite = sprite;
    }

    private void Animation()
    {
        if (_tween == null)
        {
            _tween = transform.DOScale(Vector3.one * 0.9f, 0.2f).SetLoops(2, LoopType.Yoyo).OnComplete(() =>
            {
                _tween = null;
            });
        }
        else
        {
            _tween.Restart();
        }
    }
}
