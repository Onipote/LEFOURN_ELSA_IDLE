using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Durability : MonoBehaviour
{
    public Manager bankAccount;
    
    public Image healthbar;
    public float maxHp = 100;
    public float hp;
    
    public GameObject tool;
    private bool isDurabilityStartLaunched = false;
    public float price;
    public float additionalDollars;
    public float hpLossInterval;

    private void Start()
    {
        hp = maxHp;
    }
    
    public void BuyTool()
    {
        if (bankAccount.coin >= price && isDurabilityStartLaunched == false)
        {
            tool.SetActive(true);
            bankAccount.coin -= price;
            if (isDurabilityStartLaunched == false) 
            {
                isDurabilityStartLaunched = true; 
                StartCoroutine(DurabilityStart());
            }
            bankAccount.dollarsAdded += additionalDollars;
        }
    }
    
    public IEnumerator DurabilityStart()
    { 
        //start tool effect (dollars added + losing hp according to the interval)
        while (hp > 0)
        {
            hp = hp - 1;
            healthbar.fillAmount = hp / maxHp;
            yield return new WaitForSeconds(hpLossInterval);
        }
        //reset info
        tool.SetActive(false);
        isDurabilityStartLaunched = false;
        hp = maxHp;
        healthbar.fillAmount = hp / maxHp;
        bankAccount.dollarsAdded -= additionalDollars;
    }
}