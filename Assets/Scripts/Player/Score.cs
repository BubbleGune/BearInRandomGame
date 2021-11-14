using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private ClickBear _clickBear;

    public int Value { get; private set; }

    public event UnityAction UpdateWallet;
    public event UnityAction IncreaseComplexity;

    private void OnEnable()
    {
        _clickBear.BearClick += OnClick;
    }

    private void OnDisable()
    {
        _clickBear.BearClick -= OnClick;
    }

    private void OnClick()
    {
        Value++;
        if (Value % 10 == 0)
            UpdateWallet?.Invoke();
        if (Value % 5 == 0)
            IncreaseComplexity?.Invoke();
        _text.text = $"—чет: {Value}";
    }
}
