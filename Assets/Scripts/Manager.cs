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
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponents");
        gameOverUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponents");
        DisableUIComponent(gameOverUIComponents);
        EnableUIComponent(startGameUIComponents);
        DisableScore(score);
    }

    public void GameOver()
    {
        EnableUIComponent(gameOverUIComponents);
    }
    private void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }

    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }
    private void EnableUIComponent(object startGameUIComponet)
    {
       foreach(GameObject obj in startGameUIComponents)
        {
            obj.SetActive(true);
        }
    }

    private void DisableUIComponent(GameObject[] gameOverUIComponents)
    {
        foreach (GameObject obj in gameOverUIComponents)
        {
            obj.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
