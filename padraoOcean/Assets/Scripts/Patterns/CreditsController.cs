using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour {


    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
