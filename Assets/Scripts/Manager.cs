using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Animator animButton;
    public Animator animWallet;
    
    public AudioSource audio1;
    public AudioSource audio2;
    private int currentSound;
    
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
        RandomizeSound();
        Debug.Log(currentSound);
        if (currentSound == 1)
        {
            audio1.Play();
        }
        else if (currentSound == 2)
        {
            audio2.Play();
        }
        
        animButton.SetTrigger("isTriggered");
        animWallet.SetTrigger("isEarningDollars");
        coin += dollarsAdded * clickMultiplier;
        myClickCounter++;
        // coin = 1$ ; dollarsAdded = T1 ; clickMultiplier = T2 & Employees
    }

    private void RandomizeSound()
    {
        currentSound = Random.Range(1,3);
    }
}
