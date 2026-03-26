using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreRedValueLabel;
    [SerializeField] private TextMeshProUGUI _scoreBlueValueLabel;
    [SerializeField] private TextMeshProUGUI _scoreGreenValueLabel;
    [SerializeField] private TextMeshProUGUI _scoreColoredValueLabel;

    // For CounterManager.IncreaseScoreEvent (UnityEvent<float>)
    public void SetScore(float totalValue)
    {
        if (_scoreRedValueLabel != null)
            _scoreRedValueLabel.text = totalValue.ToString();
    }

    public void SetScoreByColors(float redValue, float blueValue, float greenValue)
    {
        if (_scoreRedValueLabel != null)
            _scoreRedValueLabel.text = redValue.ToString();
        if (_scoreBlueValueLabel != null)
            _scoreBlueValueLabel.text = blueValue.ToString();
        if (_scoreGreenValueLabel != null)
            _scoreGreenValueLabel.text = greenValue.ToString();
    }

    // For CounterManager.IncreaseScoreEvent (UnityEvent<float,float,float,float>)
    public void SetScoreByColors(float redValue, float blueValue, float greenValue, float coloredValue)
    {
        SetScoreByColors(redValue, blueValue, greenValue);
        if (_scoreColoredValueLabel != null)
            _scoreColoredValueLabel.text = coloredValue.ToString();
    }
}
