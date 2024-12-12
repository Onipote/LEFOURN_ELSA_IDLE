using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingAtStores : MonoBehaviour
{
    public Manager bankAccount;

    public GameObject upgWoodType, upgWoodShape, upgPaintPot, upgScrewCovers, upgHandleType, upgEmblemType;
    public GameObject upgSheetType, upgCushionType, upgPaddingType, upgNameplateType;
    public bool upg1IsActivated = false, upg2IsActivated = false, upg3IsActivated = false, upg4IsActivated = false;
    public bool upg5IsActivated = false, upg6IsActivated = false, upg7IsActivated = false, upg8IsActivated = false;
    public bool upg9IsActivated = false, upg10IsActivated = false;
    
    public void BuyWoodType()
    {
        if (bankAccount.coin >= 1 && upg1IsActivated == false)
        {
            upgWoodType.SetActive(true);
            bankAccount.coin -= 1;
            upg1IsActivated = true;
        }
    }
    public void BuyWoodShape()
    {
        if (bankAccount.coin >= 2 && upg1IsActivated == true && upg2IsActivated == false)
        {
            upgWoodShape.SetActive(true);
            bankAccount.coin -= 2;
            upg2IsActivated = true;
        }
    }
    
    public void BuyPaintPot()
    {
        if (bankAccount.coin >= 3 && upg2IsActivated == true && upg3IsActivated == false)
        {
            upgPaintPot.SetActive(true);
            bankAccount.coin -= 3;
            upg3IsActivated = true;
        }
    }

    public void BuyScrewCovers()
    {
        if (bankAccount.coin >= 4 && upg3IsActivated == true && upg4IsActivated == false)
        {
            upgScrewCovers.SetActive(true);
            bankAccount.coin -= 4;
            upg4IsActivated = true;
        }
    }
    
    public void BuyHandleType()
    {
        if (bankAccount.coin >= 5 && upg4IsActivated == true && upg5IsActivated == false)
        {
            upgHandleType.SetActive(true);
            bankAccount.coin -= 5;
            upg5IsActivated = true;
        }
    }
    
    public void BuyEmblemType()
    {
        if (bankAccount.coin >= 6 && upg5IsActivated == true && upg6IsActivated == false)
        {
            upgEmblemType.SetActive(true);
            bankAccount.coin -= 6;
            upg6IsActivated = true;
        }
    }
    
    public void BuySheetType()
    {
        if (bankAccount.coin >= 7 && upg6IsActivated == true && upg7IsActivated == false)
        {
            upgSheetType.SetActive(true);
            bankAccount.coin -= 7;
            upg7IsActivated = true;
        }
    }
    
    public void BuyCushionsType()
    {
        if (bankAccount.coin >= 8 && upg7IsActivated == true && upg8IsActivated == false)
        {
            upgCushionType.SetActive(true);
            bankAccount.coin -= 8;
            upg8IsActivated = true;
        }
    }
    
    public void BuyPaddingType()
    {
        if (bankAccount.coin >= 9 && upg8IsActivated == true && upg9IsActivated == false)
        {
            upgPaddingType.SetActive(true);
            bankAccount.coin -= 9;
            upg9IsActivated = true;
        }
    }
    
    public void BuyNameplateType()
    {
        if (bankAccount.coin >= 10 && upg9IsActivated == true && upg10IsActivated == false)
        {
            upgNameplateType.SetActive(true);
            bankAccount.coin -= 10;
            upg10IsActivated = true;
        }
    }
}
