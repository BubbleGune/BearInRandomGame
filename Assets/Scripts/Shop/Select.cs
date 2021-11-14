using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CanvasGroup))]
public class Select : MonoBehaviour, IPointerClickHandler
{
    private CanvasGroup _canvasGroup;

    public event UnityAction SelectCollected;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SelectCollected?.Invoke();
    }
    public void Open() => _canvasGroup.alpha = 1;
    public void Close() => _canvasGroup.alpha = 0;
}