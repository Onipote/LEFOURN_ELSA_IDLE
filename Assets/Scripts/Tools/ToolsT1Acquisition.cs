using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsT1Acquisition : MonoBehaviour
{
    public Manager bankAccount;
    public bool shearsAcquired= false, hatchetAcquired = false, merlinAcquired = false, sabersawAcquired = false, logsawAcquired = false, chainsawAcquired = false;
    
    public void BuyShears()
    {
        if (bankAccount.coin >= 1 && shearsAcquired == false)
        {
            bankAccount.coin -= 1;
            shearsAcquired = true;
            bankAccount.dollarsAdded += 1;
        }
    }
    
    public void BuyHatchet()
    {
        if (bankAccount.coin >= 2 && shearsAcquired == true && hatchetAcquired == false)
        {
            bankAccount.coin -= 2;
            hatchetAcquired = true;
            bankAccount.dollarsAdded += 6;
        }
    }
    
    public void BuyMerlin()
    {
        if (bankAccount.coin >= 3 && hatchetAcquired == true && merlinAcquired == false)
        {
            bankAccount.coin -= 3;
            merlinAcquired = true;
            bankAccount.dollarsAdded += 8;
        }
    }
    
    public void BuySabersaw()
    {
        if (bankAccount.coin >= 4 && merlinAcquired == true && sabersawAcquired == false)
        {
            bankAccount.coin -= 4;
            sabersawAcquired = true;
            bankAccount.dollarsAdded += 112;
        }
    }
    
    public void BuyLogsaw()
    {
        if (bankAccount.coin >= 5 && sabersawAcquired == true && logsawAcquired == false)
        {
            bankAccount.coin -= 5;
            logsawAcquired = true;
            bankAccount.dollarsAdded += 0;
        }
    }
    
    public void BuyChainsaw()
    {
        if (bankAccount.coin >= 6 && logsawAcquired == true && chainsawAcquired == false)
        {
            bankAccount.coin -= 6;
            chainsawAcquired = true;
            bankAccount.dollarsAdded += 0;
        }
    }
}