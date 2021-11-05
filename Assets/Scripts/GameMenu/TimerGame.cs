using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class TimerGame : MonoBehaviour
{
    [SerializeField] private float _time;

    private CanvasGroup _visible;

    public float Seconds => _time;

    public event UnityAction<float> TimeGone;

    private void Awake()
    {
        _visible = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        CloseMenu();
        TimeGone?.Invoke(_time);
    }

    public void ShowMenu()
    {
        _visible.alpha = 1;
    }

    public void CloseMenu()
    {
        _visible.alpha = 0;
    }
}
