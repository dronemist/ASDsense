using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_menu : MonoBehaviour
{
    public void gotomenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void gotoGame()
    {
        SceneManager.LoadScene("ASD_game_scene");

    }
}
