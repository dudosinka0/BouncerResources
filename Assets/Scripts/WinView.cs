using UnityEngine;
using TMPro;

public class WinView : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private CounterManager _counterManager;
    [SerializeField] private PlayerMovements _playerMovements;
    [SerializeField] private TextMeshProUGUI _winLabel;

    [Header("Settings")]
    [SerializeField] private string _winText = "YOU WIN";

    private bool _isWinShown;

    private void Start()
    {
        if (_winLabel != null)
            _winLabel.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_isWinShown) return;
        if (_counterManager == null || _playerMovements == null || _winLabel == null) return;

        if (_counterManager.TotalCollected >= _playerMovements.PrizeCount)
        {
            _isWinShown = true;
            _winLabel.text = _winText;
            _winLabel.gameObject.SetActive(true);
        }
    }
}
