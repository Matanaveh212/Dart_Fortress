using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallHealth2 : MonoBehaviour
{
    public Image debrisWall;
    public DartScoreCalculator dartScoreCalculator1;
    public DartScoreCalculator dartScoreCalculator2;
    public GameObject scoreCanvas1;
    public GameObject scoreCanvas2;
    float damage1;
    float damage2;

    public void TakeDamage1()
    {
        damage1 = dartScoreCalculator1.score;
        debrisWall.fillAmount -= damage1 / 1000;
        if (debrisWall.fillAmount <= 0) FindObjectOfType<LevelLoader>().LoadNextLevel();
        StartCoroutine("ActiveScoreCanvas1");
    }

    IEnumerator ActiveScoreCanvas1()
    {
        scoreCanvas1.SetActive(false);
        yield return new WaitForSeconds(2);
        scoreCanvas1.SetActive(true);
    }

    public void TakeDamage2()
    {
        damage2 = dartScoreCalculator2.score;
        debrisWall.fillAmount -= damage2 / 1000;
        if (debrisWall.fillAmount <= 0) FindObjectOfType<LevelLoader>().LoadNextLevel();
        StartCoroutine("ActiveScoreCanvas2");
    }

    IEnumerator ActiveScoreCanvas2()
    {
        scoreCanvas2.SetActive(false);
        yield return new WaitForSeconds(2);
        scoreCanvas2.SetActive(true);
    }
}
