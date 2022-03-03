using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GUIManager : MonoBehaviour
{
    //setUp UI Objects 
    [SerializeField] private GameObject gameOverUI;

    [SerializeField] private bool fadeInGOS = false; //fade in Game Over Screen
    [SerializeField] private bool fadeOutGOS = false; //fade out Game Over Screen


    private static GUIManager instance;

    public static GUIManager GetInstance { get => instance;  }

    private void Awake()
    {
        instance = this;
    }

    public void restart()
    {
        Invoke("hideGameOverScreen", 1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void goToMainMenu()
    {

    }

    public void showGameOverScreen()
    {
        gameOverUI.SetActive(true);
        fadeInGOS = true;
    }

    public void hideGameOverScreen()
    {
        fadeOutGOS = true;
    }

    private void Update()
    {
        if(fadeInGOS)
        {
            if(gameOverUI.GetComponent<CanvasGroup>().alpha < 1)
            {
                gameOverUI.GetComponent<CanvasGroup>().alpha += Time.deltaTime;
                if(gameOverUI.GetComponent<CanvasGroup>().alpha >= 1)
                {
                    fadeInGOS = false;
                }
            }
        }

        if(fadeOutGOS)
        {
            if(gameOverUI.GetComponent<CanvasGroup>().alpha >= 1)
            {
                gameOverUI.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
                if(gameOverUI.GetComponent<CanvasGroup>().alpha <= 0)
                {
                    fadeOutGOS = false;
                    gameOverUI.SetActive(false);
                }
            }
        }
        
    }



}
