using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float coin;
    public TextMeshProUGUI coinText;
    public float clickMultiplier;
    public float dollarsAdded;
    private void Start()
    {
        coin = 0;
    }

    private void Update()
    {
        coinText.text = "BANK : " + coin.ToString("0");
    }

    public void Working()
    {
        coin += dollarsAdded * clickMultiplier;
        // coin = 1$ ; dollarsAdded = T1 ; clickMultiplier = T2 & Employees
    }
}
