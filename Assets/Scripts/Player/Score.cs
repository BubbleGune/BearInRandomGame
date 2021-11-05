using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private ClickBear _clickBear;

    public int Value { get; private set; }

    public event UnityAction UpdateWallet;

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
        _text.text = $"—чет: {Value}";
    }
}
