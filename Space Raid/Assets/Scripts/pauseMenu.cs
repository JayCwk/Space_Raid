
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
}
