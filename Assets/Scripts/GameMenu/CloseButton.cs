using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CloseButton : MonoBehaviour
{
    [SerializeField] private Button _closeButton;

    private void OnEnable()
    {
        _closeButton.onClick.AddListener(LoadMainScense);
    }

    private void OnDisable()
    {
        _closeButton.onClick.RemoveListener(LoadMainScense);
    }

    public void LoadMainScense()
    {
        SceneManager.LoadScene(0);
    }
}
