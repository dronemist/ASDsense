using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gameManagementnormal : MonoBehaviour
{
    public Transform player;
    public Text score_text;
    public float score = 0f;
    public Image healthbar;
    public float scoring_factor = 10;
    public float health = 100f;
    private float last_position;
    float GetScore()
    {
        return score;
    }
    private void Update()
    {
        score += (Mathf.Abs(last_position - player.position.z)) * scoring_factor;
        last_position = player.position.z;
        score_text.text = score.ToString("0");
        healthbar.fillAmount = (health / 100f);
    }
}
