using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score_updater : MonoBehaviour
{
    TextMesh.text = "High Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
}
