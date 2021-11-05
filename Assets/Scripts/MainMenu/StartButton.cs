using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StartButton : MonoBehaviour
{
    [SerializeField] private Button _startButton;

    private void OnEnable()
    {
        _startButton.onClick.AddListener(LoadGameScene);
    }

    private void OnDisable()
    {
        _startButton.onClick.RemoveListener(LoadGameScene);
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
