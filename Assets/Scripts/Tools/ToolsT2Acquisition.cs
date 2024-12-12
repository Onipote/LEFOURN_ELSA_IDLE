using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsT2Acquisition : MonoBehaviour
{
    public Manager bankAccount;
    public bool butterKnifeAcquired = false, slicingKnifeAcquired = false, kiritsukeKnifeAcquired = false, cleaverAcquired = false, butchersSawAcquired = false;
    
    public void BuyButterKnife()
    {
        if (bankAccount.coin >= 1 && butterKnifeAcquired == false)
        {
            bankAccount.coin -= 1;
            butterKnifeAcquired = true;
            bankAccount.clickMultiplier = 2f;
        }
    }
    
    public void BuySlicingKnife()
    {
        if (bankAccount.coin >= 3 && butterKnifeAcquired == true && slicingKnifeAcquired == false)
        {
            bankAccount.coin -= 3;
            slicingKnifeAcquired = true;
            bankAccount.clickMultiplier = 3f;
        }
    }
    
    public void BuyKiritsukeKnife()
    {
        if (bankAccount.coin >= 600 && slicingKnifeAcquired == true && kiritsukeKnifeAcquired == false)
        {
            bankAccount.coin -= 600;
            kiritsukeKnifeAcquired = true;
            bankAccount.clickMultiplier = 4f;
        }
    }
    
    public void BuyCleaver()
    {
        if (bankAccount.coin >= 900 && kiritsukeKnifeAcquired == true && cleaverAcquired == false)
        {
            bankAccount.coin -= 900;
            cleaverAcquired = true;
            bankAccount.clickMultiplier = 5f;
        }
    }
    
    public void BuyButcherSaw()
    {
        if (bankAccount.coin >= 1500 && cleaverAcquired == true && butchersSawAcquired == false)
        {
            bankAccount.coin -= 1500;
            butchersSawAcquired = true;
            bankAccount.clickMultiplier = 6f;
        }
    }
}
