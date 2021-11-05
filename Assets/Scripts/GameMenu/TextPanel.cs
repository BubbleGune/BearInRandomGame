using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ClickBear))]
public class TextPanel : MonoBehaviour
{
    [SerializeField] private string[] _arrayWord;
    [SerializeField] private Text _text;

    private ClickBear _click;

    private void Awake()
    {
        _click = GetComponent<ClickBear>();
    }

    private void OnEnable()
    {
        _click.BearClick += ChangeTextPanel;
    }

    private void OnDisable()
    {
        _click.BearClick -= ChangeTextPanel;
    }

    private int GetRandomValue()
    {
        return Random.Range(0, _arrayWord.Length);
    }

    public void ChangeTextPanel()
    {
        _text.text = _arrayWord[GetRandomValue()];
    }

}
