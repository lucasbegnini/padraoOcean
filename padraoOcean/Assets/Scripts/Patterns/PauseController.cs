using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

    //Variavel de Armazenamento do status do jogo - true se tiver play.
    private bool _gameStatus;
    [SerializeField]
    private GameObject PanelPause;
    [SerializeField]
    private GameObject ButtonPause;
    // Use this for initialization
    void Start () {
        _gameStatus = true;
    }

    public void pauseGame()
    {
        if (_gameStatus.Equals(true))
        {
            _gameStatus = false;
            PanelPause.SetActive(true);
            ButtonPause.SetActive(false);
            Time.timeScale = 0.0f;
        }
        else {
            _gameStatus = true;
            PanelPause.SetActive(false);
            ButtonPause.SetActive(true);
            Time.timeScale = 1.0f;
        }

       // Debug.Log(_gameStatus);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Reload()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void Continue()
    {
        pauseGame();
    }

}
