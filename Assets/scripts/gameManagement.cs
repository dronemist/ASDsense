﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gameManagement : MonoBehaviour
{
    public Transform player;
    public Text score_text;
    public static int coin_total = 0;
    static float score = 0f;
    public float scoring_factor = 10;
    public KeyCode incr_scoring;
    float GetScore()
    {
        return score;
    }
    private void Update()
    {
        scoring_factor -= 0.05f * Time.deltaTime;
        scoring_factor = Mathf.Max(1f, scoring_factor);
        if(Input.GetKeyUp(incr_scoring))
        {
            scoring_factor += (0.3f);
            scoring_factor = Mathf.Min(10, scoring_factor);
        }
        score = player.position.z * scoring_factor;
        score_text.text = score.ToString("0");
    }
}
