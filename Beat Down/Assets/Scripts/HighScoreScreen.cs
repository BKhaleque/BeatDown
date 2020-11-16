using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class HighScoreScreen : MonoBehaviour
{
    int highScore;
    int currentScore;
    public Text highScoreText;
    public Text currentScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");

        }
        else
        {
            PlayerPrefs.SetInt("HighScore", 0);
            highScore = 0;
        }

        if (PlayerPrefs.HasKey("Score"))
        {
            currentScore = PlayerPrefs.GetInt("Score");

        }
        else
        {
            PlayerPrefs.SetInt("Score", 0);
            currentScore = 0;
        }

        highScoreText.text += " " + highScore + " ";
        currentScoreText.text += " " + currentScore + " ";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
