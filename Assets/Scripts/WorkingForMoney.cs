using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WorkingForMoney : MonoBehaviour
{
    public int coin;
    public TextMeshProUGUI coinText;

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
        coin++;
    }
}
