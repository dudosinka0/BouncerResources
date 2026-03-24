using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreValueLabel;

    public void SetScore(float value)
    {
        if (value < 6) _scoreValueLabel.text = value.ToString();
        else _scoreValueLabel.text = "You Win!";
    }
}
