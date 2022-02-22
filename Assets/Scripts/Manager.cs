using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject[] startGameUIComponents;
    GameObject[] gameOverUIComponents;
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponents");
        gameOverUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponents");
        DisableUIComponent(gameOverUIComponents);
        EnableUIComponent(startGameUIComponents);
        DisableScore(score);
    }

    public void DisableStartUI()
    {
        DisableUIComponent(startGameUIComponents);
    }

    public void GameOver()
    {
        EnableUIComponent(gameOverUIComponents);
        Time.timeScale = 0;
    }

    public void ShowScore()
    {
        score.SetActive(true);
    }

    public void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }

    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }
    private void EnableUIComponent(GameObject[] uiObjects)
    {
        Debug.Log("Enable");
       foreach(GameObject obj in uiObjects)
        {
            obj.SetActive(true);
        }
    }

    private void DisableUIComponent(GameObject[] uiObjects)
    {
        foreach (GameObject obj in uiObjects)
        {
            obj.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
