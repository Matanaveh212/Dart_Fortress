using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGold0 : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Gold", 0);
    }
}
