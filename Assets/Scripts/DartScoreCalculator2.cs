using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DartScoreCalculator2 : MonoBehaviour
{
    public TMP_InputField numberInput;
    public TMP_Text scoreText;
    public int score;

    private void Update()
    {
        CalculateDartThrowScore();
    }

    private void CalculateDartThrowScore()
    {
        if (int.Parse(numberInput.text) < 0 || int.Parse(numberInput.text) > 20)
        {
            score = 0;
            scoreText.text = score.ToString(); 
        }
    }
  
    public void CalculateBullseyeScore()
    {
        score = 50;
        scoreText.text = score.ToString();
    }

    public void CalculateOuterBullScore()
    {
        score = 25;
        scoreText.text = score.ToString();
    }

    public void Single()
    {
        score = int.Parse(numberInput.text) * 1;
        scoreText.text = score.ToString();
    }

    public void Double()
    {
        score = int.Parse(numberInput.text) * 2;
        scoreText.text = score.ToString();
    }

    public void Triple()
    {
        score = int.Parse(numberInput.text) * 3;
        scoreText.text = score.ToString();
    }

    public void ResetScores()
    {
        score = 0;
        scoreText.text = score.ToString();
        numberInput.text = "";   
    }
}

            

