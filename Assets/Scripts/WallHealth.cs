using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallHealth : MonoBehaviour
{
    public Image debrisWall;
    public DartScoreCalculator dartScoreCalculator;
    public GameObject scoreCanvas;
    public GameObject overlay;
    public GameObject liam2;
    public GameObject missionBoard;
    float currentHealth = 1;
    float damage;

    public void TakeDamage()
    {
        damage = dartScoreCalculator.score;
        currentHealth -= damage / 1000;
        debrisWall.fillAmount = currentHealth;
        if(currentHealth <= 0.4) FindObjectOfType<LevelLoader>().LoadNextLevel();
        StartCoroutine("ActiveScoreCanvas");
    }

    IEnumerator ActiveScoreCanvas()
    {
        scoreCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        scoreCanvas.SetActive(true);
    }
}
