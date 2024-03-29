using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LevelBarRoot : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI _levelTextUI;
    [SerializeField] private Image _imageFill;
    [SerializeField] private AudioSource _levelUpdate;
    private const string LEVEL_TEXT = "Уровень: ";
    private bool _isStart;

    public void FillChanged(Score score) {
        if (score == null) {
            return;
        }
        _imageFill.fillAmount = (score.CurrentValue - score.MinValue) / (score.MaxValue - score.MinValue);
    }

    public void LevelUpdate(int level) {
        level++;
        _levelTextUI.text = LEVEL_TEXT + level;

        //if (_isStart) {
        //    _levelUpdate.PlayOneShot(_levelUpdate.clip);
        //}
        //_isStart = true;
    }
    public void PlayNewLevel()
    {
        _levelUpdate.PlayOneShot(_levelUpdate.clip);
    }
}
