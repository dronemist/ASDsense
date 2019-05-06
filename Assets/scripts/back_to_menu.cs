using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back_to_menu : MonoBehaviour
{
    public Text Asd_score;
    public Text normal_score;
    public Text total_score;
    public Text high_score;
    private void Start()
    {
        Asd_score.text = "ASD Score: " + PlayerPrefs.GetFloat("ASD_score", 0).ToString("0");
        normal_score.text = "Normal Score: " + PlayerPrefs.GetFloat("Normal_score", 0).ToString("0");
        total_score.text = "Total Score: " + (PlayerPrefs.GetFloat("ASD_score", 0) + PlayerPrefs.GetFloat("Normal_score", 0)).ToString("0");
        high_score.text = "High Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }
    public void gotomenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void gotoGame()
    {
        SceneManager.LoadScene("ASD_game_scene");

    }
}
