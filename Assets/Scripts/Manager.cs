using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public ToolsT1Acquisition t1Effect;
    public ToolsT2Acquisition t2Effect;
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
    }
}
