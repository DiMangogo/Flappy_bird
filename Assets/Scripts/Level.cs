using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
  public void ReloadLevel()
    {
       //SceneManager.LoadScene("Game Scene");
       // Одно и токже
        SceneManager.LoadScene(0);
    }

    public void LoadMainManu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }

    public void Exit() {Application.Quit();}

    private void ResumeGame() { Time.timeScale = 1;}

    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
        ResumeGame();
    }
}