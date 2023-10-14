using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GoldCoin : MonoBehaviour
{
    public int finalGold;
    public float duration; // The time in seconds you want the increment to take
    public TMP_Text goldText;
    public Button fortressButton;

    void Start()
    {
        StartCoroutine("GoldUp");
    }

    IEnumerator GoldUp()
    {
        float startTime = Time.time;

        for (float t = 0; t < 1; t = (Time.time - startTime) / duration)
        {
            int currentGold = Mathf.RoundToInt(Mathf.Lerp(0, finalGold, t));
            goldText.text = currentGold.ToString();
            yield return null;
        }

        goldText.text = finalGold.ToString();
        PlayerPrefs.SetInt("Gold", 10000);
        yield return new WaitForSeconds(1);
        fortressButton.gameObject.SetActive(true);

    }

}
