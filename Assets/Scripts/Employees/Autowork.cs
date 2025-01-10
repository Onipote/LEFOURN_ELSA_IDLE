using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Autowork : MonoBehaviour
{
    public Manager bankAccount;
    public CardSelected cardSelected;
    public float intervalAutoClick;
    
    private void Start()
    {
        cardSelected = FindObjectOfType<CardSelected>();   

        StartCoroutine(Auto());
    }

    public IEnumerator Auto()
    {
        while (true)
        {
            if (cardSelected.autoworkStart)
            {
                bankAccount.animWallet.SetTrigger("isEarningDollars");
                bankAccount.coin += 100;
            }
            yield return new WaitForSeconds(intervalAutoClick);
        }
    }
}