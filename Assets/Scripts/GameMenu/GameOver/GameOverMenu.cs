using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TimerGame))]
public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private Text _text;

    private TimerGame _timerGame;

    public float Money { get; private set; }

    private void Awake()
    {
        _timerGame = GetComponent<TimerGame>();
    }

    private void Start()
    {
        Money = PlayerPrefs.GetFloat("Money");
        _text.text = _timerGame.Seconds.ToString();
    }

    private void OnEnable()
    {
        _timerGame.TimeGone += OnTimeGone;
    }

    private void OnDisable()
    {
        _timerGame.TimeGone -= OnTimeGone;
    }

    private void OnTimeGone(float time)
    {
        while(time > 0)
        {
            time -= Time.deltaTime;
            _text.text = _timerGame.Seconds.ToString();
        }
        if(time <= 0)
        {
            _timerGame.ShowMenu();
        }
    }
}
