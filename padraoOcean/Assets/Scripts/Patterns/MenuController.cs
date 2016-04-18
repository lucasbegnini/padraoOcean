using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    [SerializeField]
    private GameObject ExitConfirmPanel;

    public void GoToGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        if (SceneManager.GetActiveScene().name.Equals("Menu"))
            ExitConfirmPanel.SetActive(true);
    }
}
