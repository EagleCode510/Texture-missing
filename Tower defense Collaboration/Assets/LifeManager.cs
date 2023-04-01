using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public Text lives;
    public int hp = 100;

    void Start()
    {
        hp = 10;
    }

    void Update()
    {
        lives.text = "Lives: " + hp.ToString() + " ";
    }

    public void ChangeLivesNegative(int damage)
    {
        hp -= damage;
    }
}