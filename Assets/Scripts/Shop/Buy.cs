using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class Buy : MonoBehaviour, IPointerClickHandler
{
    private CanvasGroup _canvasGroup;

    public event UnityAction BuyCollected;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        BuyCollected?.Invoke();
    }
    public void Open() => _canvasGroup.alpha = 1;
    public void Destroyed(Button buy) => Destroy(buy);
}
