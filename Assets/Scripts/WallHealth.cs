using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallHealth : MonoBehaviour
{
    public Image debrisWall;
    public DartScoreCalculator dartScoreCalculator;
    public GameObject scoreCanvas;
    float damage;

    public void TakeDamage()
    {
        damage = dartScoreCalculator.score;
        debrisWall.fillAmount -= damage / 1000;
        if(debrisWall.fillAmount <= 0.4) FindObjectOfType<LevelLoader>().LoadNextLevel();
        StartCoroutine("ActiveScoreCanvas");
    }

    IEnumerator ActiveScoreCanvas()
    {
        scoreCanvas.SetActive(false);
        yield return new WaitForSeconds(2);
        scoreCanvas.SetActive(true);
    }
}
