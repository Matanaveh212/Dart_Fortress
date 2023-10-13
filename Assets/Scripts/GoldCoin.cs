using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GoldCoin : MonoBehaviour
{
    public int finalGold;
    public TMP_Text goldText;
    public Button fortressButton;

    void Start()
    {
        StartCoroutine("GoldUp");
    }

    IEnumerator GoldUp()
    {
        for (int i = 0; i <= finalGold; i=i+10)
        {
            goldText.text = i.ToString();
            yield return new WaitForSeconds(0.0008f); 
        }

        PlayerPrefs.SetInt("Gold", 10000);
        yield return new WaitForSeconds(1);
        fortressButton.gameObject.SetActive(true);

    }

}
