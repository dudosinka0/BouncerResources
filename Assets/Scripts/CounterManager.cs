using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CounterManager : MonoBehaviour
{
    public UnityEvent<float> IncreaseScoreEvent;

    private float _value;

    public void AddScore(float value)
    {
        _value += value;
        IncreaseScoreEvent.Invoke(_value);
    }
}
