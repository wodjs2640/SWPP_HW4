using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public Button button;
    public GameObject Title;
    public GameObject Stage;

    private bool isPause;
    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Stage.SetActive(true);
        Title.SetActive(false);
    }

    public void PauseGame()
    {
        ColorBlock colorBlock = button.colors;
        if (!isPause)
        {
            Time.timeScale = 0;
            isPause = true;
            colorBlock.normalColor = Color.red;
            colorBlock.selectedColor = Color.red;
        }
        else if (isPause)
        {
            Time.timeScale = 1;
            isPause = false;
            colorBlock.normalColor = Color.white;
            colorBlock.selectedColor = Color.white;
        }
    }
}
