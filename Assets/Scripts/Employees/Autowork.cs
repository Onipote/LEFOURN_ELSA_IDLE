using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autowork : MonoBehaviour
{
    public Manager bankAccount;
    public CardSelected cardSelected;
    public float value;
    
    private void Start()
    {
        cardSelected = FindObjectOfType<CardSelected>();
        StartCoroutine(Auto());
    }

    public IEnumerator Auto()
    {
        while (cardSelected.autoworkStart == true)
        {
            bankAccount.coin++;
            yield return new WaitForSeconds(value);
        }
    }
}
