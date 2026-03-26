using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScen_Door1");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Scene");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
}