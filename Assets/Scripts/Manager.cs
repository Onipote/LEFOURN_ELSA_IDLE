using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Animator animButton;
    public Animator animWallet;

    public float coin;
    public TextMeshProUGUI coinText;
    public float clickMultiplier;
    public float dollarsAdded;
    public int myClickCounter;

    private void Start()
    {
        coin = 0;
    }

    private void Update()
    {
        coinText.text = coin.ToString("$000 000 000");
    }

    public void Working()
    {
        animButton.SetTrigger("isTriggered");
        animWallet.SetTrigger("isEarningDollars");
        coin += dollarsAdded * clickMultiplier;
        myClickCounter++;
        // coin = 1$ ; dollarsAdded = T1 ; clickMultiplier = T2 & Employees
    }
}
