using UnityEngine;

public class Score {
    public float MinValue { get; private set; }
    public float MaxValue { get; private set; }
    public float CurrentValue { get; private set; }

    public Score(float minValue, float maxValue, float currentValue) {
        MinValue = minValue;
        MaxValue = maxValue;
        CurrentValue = currentValue;
    }

    public bool CanStartNextLevel(float value) {
        CurrentValue += Mathf.Abs(value);
        return CurrentValue >= MaxValue;
    }

    public void NextLevel(float newMaxValue) {
        MinValue = MaxValue;
        MaxValue = newMaxValue;
    }
}
