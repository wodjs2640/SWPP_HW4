using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public static GameStart instance;

    public Button pause;
    public Button start;
    public Button restart;
    public GameObject Title;
    public GameObject Stage;
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject gameOver;
    public TextMeshProUGUI leftUp;

    private int stage;
    private int life;
    private int money;

    private bool isPause;
    public bool isPlaying;
    public bool isGameOver;
    // Start is called before the first frame update
    private void Awake()
    {
        if (GameStart.instance == null)
        {
            GameStart.instance = this;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Stage.SetActive(true);
        Title.SetActive(false);
        Time.timeScale = 1;
    }
    void Start()
    {
        isPause = false;
        isGameOver = false;
        isPlaying = false;
        stage = 1;
        life = 1;
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        leftUp.text = "Stage : " + stage + "\nLife : " + life + "\nMoney : " + money;
        if (isGameOver)
        {
            Time.timeScale = 0;
            pause.interactable = false;
            start.interactable = false;
        }
    }

    public void StartGame()
    {
        Stage.SetActive(true);
        Title.SetActive(false);
    }

    public void PauseGame()
    {
        TextMeshProUGUI pauseText = pause.GetComponentInChildren<TextMeshProUGUI>();
        if (!isPause)
        {
            Time.timeScale = 0;
            isPause = true;
            pauseText.color = Color.red;
        }
        else if (isPause)
        {
            Time.timeScale = 1;
            isPause = false;
            pauseText.color = Color.black;
        }
    }

    public void StageStart()
    {
        TextMeshProUGUI startText = start.GetComponentInChildren<TextMeshProUGUI>();
        if (stage == 1)
        {
            stage1.SetActive(true);
            isPlaying = true;
            startText.color = Color.red;
        }
        else if (stage == 2)
        {
            stage2.SetActive(true);
            isPlaying = true;
            startText.color = Color.red;
        }
        else if (stage == 3)
        {
            stage3.SetActive(true);
            isPlaying = true;
            startText.color = Color.red;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
