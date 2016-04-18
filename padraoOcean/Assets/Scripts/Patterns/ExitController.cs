using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour {

    [SerializeField]
    private GameObject ExitConfirmPanel;

    public void ExitGame()
    {
        Application.Quit();
       // Debug.Log("Saiu");
    }

    public void CancelExitGame()
    {
       // Debug.Log("Cancelou");
        if (SceneManager.GetActiveScene().name.Equals("Menu"))
            ExitConfirmPanel.SetActive(false);
    }
}
