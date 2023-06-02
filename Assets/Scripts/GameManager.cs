using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ui;
    [SerializeField] GameObject uiGameName;
    [SerializeField] GameObject uiPlayButton;
    [SerializeField] GameObject uiLife;
    [SerializeField] GameObject uiInstruction;
    [SerializeField] GameObject uiScore;
    [SerializeField] GameObject uiScoreValue;
    [SerializeField] GameObject uiLifeValue;

    

    public int level = 1;
    public int score = 0;
    public int life  = 10;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(this.ui.gameObject);

        UiStatus(true, false);
    }

    private void Start()
    {
        ResetGame();
    }

    private void Update()
    {
        this.uiScoreValue.GetComponent<Text>().text = score.ToString();
        this.uiLifeValue.GetComponent<Text>().text = life.ToString();

        if(life <=0)
        {
           // SceneManager.LoadScene(sceneBuildIndex(2));
        }
    }
    private void ResetGame()
    {
        life  = 10;
        score = 0;
    }

    public void NewGame()
    {

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
        uiInstruction.SetActive(main);

        uiScore.SetActive(game);
        uiLife.SetActive(game);
        uiLifeValue.SetActive(game);
        uiScoreValue.SetActive(game);
    }

    public void AddScore()
    {
        score++;
    }

    public void LifeUpdate()
    {
        life--;
    }

}
