using UnityEngine;
using UnityEngine.Events;

public class CounterManager : MonoBehaviour
{
    public UnityEvent<float, float, float, float> IncreaseScoreEvent;

    [Header("Per-color counters")]
    [SerializeField] private int _red;
    [SerializeField] private int _green;
    [SerializeField] private int _blue;
    [SerializeField] private int _colored;

    public int Red => _red;
    public int Green => _green;
    public int Blue => _blue;
    public int Colored => _colored;
    public int TotalCollected => _red + _green + _blue + _colored;

    public void AddScore(ColorId colorId, int amount = 1)
    {
        if (amount == 0) return;

        switch (colorId)
        {
            case ColorId.Red:
                _red += amount;
                break;
            case ColorId.Green:
                _green += amount;
                break;
            case ColorId.Blue:
                _blue += amount;
                break;
            case ColorId.Colored:
                _colored += amount;
                break;
            default:
                // Unknown color is ignored.
                break;
        }

        NotifyScoresChanged();
    }

    public int GetScore(ColorId colorId)
    {
        return colorId switch
        {
            ColorId.Red => _red,
            ColorId.Green => _green,
            ColorId.Blue => _blue,
            ColorId.Colored => _colored,
            _ => 0
        };
    }

    private void NotifyScoresChanged()
    {
        IncreaseScoreEvent?.Invoke(_red, _blue, _green, _colored);
    }
}
