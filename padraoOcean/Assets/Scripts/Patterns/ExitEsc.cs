using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitEsc : MonoBehaviour {

    [SerializeField]
    private string scenetoGo;
    [SerializeField]
    private GameObject ExitConfirmPanel;

    void Start()
    {
        if(SceneManager.GetActiveScene().name.Equals("Menu"))
            ExitConfirmPanel.SetActive(false);
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name.Equals("Menu"))
            {
                ExitConfirmPanel.SetActive(true);
            }
            else {
                SceneManager.LoadScene(scenetoGo);
            }
        }
	}
}
