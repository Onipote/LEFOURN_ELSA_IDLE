using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_ToolsT2 : MonoBehaviour
{
    public Manager bankAccount;
    public AudioSource buyingTools;
    public GameObject tool;
    public float price;
    public float additionalClick;
    public bool isAcquired;
        
    public void BuySpecialTool()
    {
        if (bankAccount.coin >= price && isAcquired == false)
        {
            buyingTools.Play();
            tool.SetActive(true);
            bankAccount.coin -= price;
            bankAccount.clickMultiplier += additionalClick;
            isAcquired = true;
        }
    }
}
