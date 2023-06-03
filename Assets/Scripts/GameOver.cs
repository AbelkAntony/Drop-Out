using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] GameObject uiGameOver;
    [SerializeField] GameObject uiResetButton;

    private void Awake()
    {
        uiGameOver.SetActive(true);
        uiResetButton.SetActive(true);
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Reset()
    {
        uiGameOver.SetActive(false);
        uiResetButton.SetActive(false);
        gameManager.NewGame();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
