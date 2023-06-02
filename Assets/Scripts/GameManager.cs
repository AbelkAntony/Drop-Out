using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
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
        
    }

 

    public void NewGame()
    {
        this.score = 0;
        this.life = 0;

        LoadLevel(1);

    }

    public void LoadLevel(int level)
    {   
        SceneManager.LoadScene("Level" + level);
    }

   
}
