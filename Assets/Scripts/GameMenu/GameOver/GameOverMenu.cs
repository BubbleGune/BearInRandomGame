using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Score _score;
    [SerializeField] private TimerGame _timerGame;

    private void OnEnable()
    {
        _timerGame.Stop += OnStop;
        _timerGame.Stop += ShowMoneyRound;
    }

    private void OnDisable()
    {
        _timerGame.Stop -= OnStop;
        _timerGame.Stop -= ShowMoneyRound;
    }

    private void OnStop()
    {
        transform.position = (new Vector2(0, 0));
    }

    private void ShowMoneyRound()
    {
        _text.text = Mathf.Round(_score.Value / 10).ToString();
    }
}
