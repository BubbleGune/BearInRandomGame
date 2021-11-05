using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickBear : MonoBehaviour, IPointerClickHandler
{
    public event UnityAction BearClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        BearClick?.Invoke();
    }
}
