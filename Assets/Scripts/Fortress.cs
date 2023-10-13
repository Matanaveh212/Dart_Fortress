using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Fortress : MonoBehaviour
{
    public TMP_Text goldText;
    public GameObject fortress;
    public Sprite foundation;

    void Start()
    {
        if(PlayerPrefs.GetString("Bought") == "Yes") fortress.GetComponent<Image>().sprite = foundation;
        goldText.text = PlayerPrefs.GetInt("Gold").ToString();
    }

    public void BuyFoundation()
    {
        if(PlayerPrefs.GetInt("Gold") >= 10000)
        {
            PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") - 10000);
            goldText.text = PlayerPrefs.GetInt("Gold").ToString();
            fortress.GetComponent<Image>().sprite = foundation;
            PlayerPrefs.SetString("Bought", "Yes");
        }
    }


}
