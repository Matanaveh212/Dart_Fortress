using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WallHealth3 : MonoBehaviour
{
    public Image debrisWall;
    public DartScoreCalculator2 dartScoreCalculator;
    public GameObject scoreCanvas;
    public Sprite onArrow;
    public Sprite offArrow;
    public Image dart1;
    public Image dart2;
    public TMP_Text healthText;
    public TMP_Text damageText;
    int health;
    int damage;

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

    public void TakeDamage()
    {
        damage = dartScoreCalculator.score;
        dartScoreCalculator.ResetScores();
        if (damage != 0)
        {
            health -= damage;
            healthText.text = health.ToString();
            damageText.text = "-" + damage.ToString();
            damageText.gameObject.SetActive(true);
            debrisWall.GetComponent<Image>().sprite = CheckWallLevel();
            StartCoroutine("DamageAnim");
            SwitchArrows();
            if (health <= 0)
            {
                health = 0;
                healthText.text = health.ToString();
                FindObjectOfType<LevelLoader>().LoadNextLevel();
            }
        }
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

    IEnumerator DamageAnim()
    {
        yield return new WaitForSeconds(1.5f);
        damageText.gameObject.SetActive(false);
    }

    void SwitchArrows()
    {
        Sprite sprite1 = dart1.GetComponent<Image>().sprite;
        Sprite sprite2 = dart2.GetComponent<Image>().sprite;

        if (sprite1 == onArrow)
        {
            sprite1 = offArrow;
            sprite2 = onArrow;
        }
        else if(sprite2 == onArrow) 
        {
            sprite1 =onArrow;
            sprite2 = offArrow;
        }

        dart1.GetComponent<Image>().sprite = sprite1;
        dart2.GetComponent<Image>().sprite = sprite2;
    }
}
