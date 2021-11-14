using UnityEngine;
using UnityEngine.UI;

public class PlayerOutWallet : MonoBehaviour
{
    [SerializeField] private Text _text;

    private float _money;

    private void Start()
    {
        _money = PlayerPrefs.GetFloat("Money");
        ShowMoney();
    }

    private void ShowMoney()
    {
        _text.text = _money.ToString();
    }
}
