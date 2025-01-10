using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatManager : MonoBehaviour
{
    public Manager manager;
    public Autowork autowork;
    public Effect_ToolsT2 effectTools;
    public MenuController menu;
    public TextMeshProUGUI clickCounterText;
    public TextMeshProUGUI clickAddedText;
    public TextMeshProUGUI dollarsEarnedCounterText;
    public TextMeshProUGUI autoClickCounterText;
    
    void Start()
    {
        manager = FindObjectOfType<Manager>();
        autowork = FindObjectOfType<Autowork>();
        effectTools = FindObjectOfType<Effect_ToolsT2>();
    }

    private void Update()
    {
        clickCounterText.text = manager.myClickCounter.ToString("0");
        clickAddedText.text = effectTools.additionalClick.ToString("1 clic x " + manager.clickMultiplier);
        dollarsEarnedCounterText.text = manager.dollarsAdded.ToString("$" + manager.dollarsAdded + "/click");
        autoClickCounterText.text = autowork.intervalAutoClick.ToString("+ $1/" + autowork.intervalAutoClick + "s");
    }

    public void Save()
    {
        menu.gameWasSaved = true;
        PlayerPrefs.SetFloat("coin", manager.coin); //$ in wallet
        PlayerPrefs.SetInt("myClickCounter", manager.myClickCounter); //number of clicks made by the player
        PlayerPrefs.SetFloat("dollarsAdded", manager.dollarsAdded); //$1+$?
        PlayerPrefs.SetFloat("clickMultiplier", manager.clickMultiplier); //1 click * ?
        PlayerPrefs.SetFloat("value", autowork.intervalAutoClick); //$50/?s
    }
}
