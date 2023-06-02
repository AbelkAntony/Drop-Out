using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ui;
    public GameObject uiGameName;
    public GameObject uiPlayButton;
    public GameObject uiScore;
    public GameObject uiLife;
    public GameObject uiInstruction;



    public int level = 1;
    public int score = 0;
    public int life  = 3;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(this.ui.gameObject);
    }

 

    public void NewGame()
    {
        this.score = 0;
        this.life = 0;

        LoadLevel(1);
        UiStatus(false, true);
    }

    public void LoadLevel(int level)
    {   
        SceneManager.LoadScene("Level" + level);
    }

    private void UiStatus(bool main, bool game)
    {
        uiGameName.SetActive(main);
        uiPlayButton.SetActive(main);
        uiScore.SetActive(game);
        uiLife.SetActive(game);
        uiInstruction.SetActive(main);
    }
   
}
