using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gameManagement : MonoBehaviour
{
    public Transform player;
    public Text score_text;
    static float score = 0f;
    public Image healthbar;
    public Image happiness;
    public float scoring_factor = 10;
    public KeyCode incr_scoring;
    public float health = 100f;
    private float last_position;
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
            scoring_factor += (0.2f);
            scoring_factor = Mathf.Min(10, scoring_factor);
        }
        score += (Mathf.Abs(last_position - player.position.z)) * scoring_factor;
        last_position = player.position.z;
        score_text.text = score.ToString("0");
        healthbar.fillAmount = (health / 100f);
        happiness.fillAmount = (scoring_factor / 10);
    }
}
