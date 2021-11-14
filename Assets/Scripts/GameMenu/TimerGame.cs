using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimerGame : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private ClickBear _click;
    [SerializeField] private Score _score;

    private float _increaseTime = 2;

    public float Seconds { get; private set; } = 3;

    public event UnityAction Stop;

    private void OnEnable()
    {
        _click.BearClick += IncreaseTimeGame;
        _score.IncreaseComplexity += IncreaseComplexity;
    }

    private void OnDisable()
    {
        _click.BearClick -= IncreaseTimeGame;
        _score.IncreaseComplexity -= IncreaseComplexity;
    }

    private void FixedUpdate()
    {
        if(Seconds > 0)
        {
            Seconds -= Time.deltaTime;
            _text.text = Seconds.ToString();
        }
        else
        {
            _text.text = 0.ToString();
            Stop?.Invoke();
        }
    }

    private void IncreaseTimeGame()
    {
        Seconds += _increaseTime;
    }

    private void IncreaseComplexity()
    {
        if(_increaseTime > 0.2f)
            _increaseTime -= 0.2f;
    }
}
