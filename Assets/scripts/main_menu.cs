using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public Text highscore;
    private void Start()
    {
        highscore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("ASD_game_scene");

    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
