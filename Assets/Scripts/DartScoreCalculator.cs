using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DartScoreCalculator : MonoBehaviour
{
    public TMP_InputField numberInput;
    public TMP_Dropdown multiplierDropdown;
    public TMP_Text scoreText;
    public int score;

    private void Update()
    {
        // Calculate the dart throw score based on inputs
        CalculateDartThrowScore();
    }

    private void CalculateDartThrowScore()
    {
        if (int.TryParse(numberInput.text, out int number))
        {
            if (number >= 1 && number <= 20) // Check if the number is within the valid range
            {
                int selectedMultiplier = multiplierDropdown.value; // Get the selected dropdown value

                score = 0;
                switch (selectedMultiplier)
                {
                    case 0: // Single
                        score = number;
                        break;
                    case 1: // Double
                        score = number * 2;
                        break;
                    case 2: // Triple
                        score = number * 3;
                        break;
                }

                // Update the score text
                scoreText.text = "Dart throw score: " + score + " points";
            }
            else
            {
                // Handle the case where the input is out of range
                scoreText.text = "Enter a number between 1 and 20";
            }
        }
        else if(numberInput.text != "")
        {
            // Handle the case where the input is not a valid integer
            scoreText.text = "Invalid Input";
        }
    }

    // Button click function for Bullseye
    public void CalculateBullseyeScore()
    {
        // Bullseye is always 50 points
        score = 50;
        scoreText.text = "Dart throw score: " + score + " points";
    }

    // Button click function for Outer Bull
    public void CalculateOuterBullScore()
    {
        // Outer Bull is always 25 points
        score = 25;
        scoreText.text = "Dart throw score: " + score + " points";
    }
}
