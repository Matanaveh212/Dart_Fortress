using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WallHealth2 : MonoBehaviour
{
    public Image debrisWall;
    public DartScoreCalculator dartScoreCalculator1;
    public DartScoreCalculator dartScoreCalculator2;
    public GameObject scoreCanvas1;
    public GameObject scoreCanvas2;
    public TMP_Text healthText;
    public TMP_Text damageText;
    public int health;
    int damage1;
    int damage2;

    public Sprite wall1;
    public Sprite wall2;
    public Sprite wall3;
    public Sprite wall4;
    public Sprite wall5;
    public Sprite wall6;
    public Sprite wall7;
    public Sprite wall8;
    public Sprite wall9;
    public Sprite wall10;

    private void Start()
    {
        health = PlayerPrefs.GetInt("NextHealth");
        healthText.text = health.ToString();
        debrisWall.GetComponent<Image>().sprite = CheckWallLevel();
    }

    public void TakeDamage1()
    {
        damage1 = dartScoreCalculator1.score;
        if (damage1 != 0)
        {
            health -= damage1;
            healthText.text = health.ToString();
            damageText.text = "-" + damage1.ToString();
            damageText.gameObject.SetActive(true);
            debrisWall.GetComponent<Image>().sprite = CheckWallLevel();
            if (health <= 0)
            {
                health = 0;
                healthText.text = health.ToString();
                FindObjectOfType<LevelLoader>().LoadNextLevel();
            }
            StartCoroutine("ActiveScoreCanvas1");
        }
    }

    IEnumerator ActiveScoreCanvas1()
    {
        scoreCanvas1.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        damageText.gameObject.SetActive(false);
        scoreCanvas1.SetActive(true);
    }

    public void TakeDamage2()
    {
        damage2 = dartScoreCalculator2.score;
        if (damage2 != 0)
        {
            health -= damage2;
            healthText.text = health.ToString();
            damageText.text = "-" + damage2.ToString();
            damageText.gameObject.SetActive(true);
            debrisWall.GetComponent<Image>().sprite = CheckWallLevel();
            if (health <= 0)
            {
                health = 0;
                healthText.text = health.ToString();
                FindObjectOfType<LevelLoader>().LoadNextLevel();
            }
            StartCoroutine("ActiveScoreCanvas2");
        }
    }

    IEnumerator ActiveScoreCanvas2()
    {
        scoreCanvas2.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        damageText.gameObject.SetActive(false);
        scoreCanvas2.SetActive(true);
    }

    private Sprite CheckWallLevel()
    {
        if (health <= 1000 && health >= 900) return wall10;
        if (health <= 900 && health >= 800) return wall9;
        if (health <= 800 && health >= 700) return wall8;
        if (health <= 700 && health >= 600) return wall7;
        if (health <= 600 && health >= 500) return wall6;
        if (health <= 500 && health >= 400) return wall5;
        if (health <= 400 && health >= 300) return wall4;
        if (health <= 300 && health >= 200) return wall3;
        if (health <= 200 && health >= 100) return wall2;
        if (health <= 100 && health >= 0) return wall1;
        if (health < 0) return wall1;
        return null;
    }
}
