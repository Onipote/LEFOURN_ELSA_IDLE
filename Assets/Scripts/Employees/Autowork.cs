using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autowork : MonoBehaviour
{
    public Manager bankAccount;
    public float value;
    
    private void Start()
    {
        StartCoroutine(Auto());
    }

    public IEnumerator Auto()
    {
        while (true)
        {
            bankAccount.coin += value;
            yield return new WaitForSeconds(2f);
        }
    }
}
