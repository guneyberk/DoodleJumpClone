using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour { 

    [SerializeField] GameObject _menu;
    public void Menu()
    {
        Time.timeScale = 0;
        _menu.SetActive(true);
        
    }
    public void Continue()
    {
        _menu.SetActive(false);
        Time.timeScale = 1;

    }
    public void Restart()
    {
        _menu.SetActive(false);
        Time.timeScale = 1;
        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneBuildIndex);

    }

    public void Exit()
    {
        Application.Quit();
    }
}
