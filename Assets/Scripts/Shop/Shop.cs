using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class Shop : MonoBehaviour
{
    [SerializeField] private Button _open;
    [SerializeField] private Button _close;

    private CanvasGroup _canvasGroup;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        Close();
    }

    private void OnEnable()
    {
        _open.onClick.AddListener(Open);
        _close.onClick.AddListener(Close);
    }

    private void OnDisable()
    {
        _open.onClick.RemoveListener(Open);
        _close.onClick.RemoveListener(Close);
    }

    private void Open() => _canvasGroup.alpha = 1;

    private void Close() => _canvasGroup.alpha = 0;
    
}
