using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class Item : MonoBehaviour
{
    [SerializeField] private Buy _buy;
    [SerializeField] private Button _buyButton;
    [SerializeField] private Select _select;

    private CanvasGroup _canvasGroup;

    private void OnEnable()
    {
        _buy.BuyCollected += OnBuyCollected;
        _select.SelectCollected += OnSelectCollected;
    }

    private void OnDisable()
    {
        _buy.BuyCollected -= OnBuyCollected;
        _select.SelectCollected -= OnSelectCollected;
    }

    private void OnBuyCollected()
    {
        _buy.Destroy(_buyButton);
        Debug.Log("=1");
    }

    private void OnSelectCollected()
    {
        Debug.Log("Selected");
    }

    public void Open() => _canvasGroup.alpha = 1;
    public void Close() => _canvasGroup.alpha = 0;
}