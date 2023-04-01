using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public float Money = 100;
    public Text Textmoney;

    void Start()
    {
        Money = 100;
    }

    void Update()
    {
        Money -= GameObject.FindWithTag("Mouse").GetComponent<MouseController>().RemoveMoneyx;
        Textmoney.text = "Money: " + Money.ToString() + " ";
    }
}
