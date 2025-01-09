using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatManager : MonoBehaviour
{
    public Manager manager;
    public Autowork autowork;
    //public Effect_ToolsT2 effectTools;
    
    public TextMeshProUGUI clickCounterText;
    public TextMeshProUGUI clickAddedText;
    public TextMeshProUGUI dollarsEarnedCounterText;
    public TextMeshProUGUI autoClickCounterText;
    void Start()
    {
        manager = FindObjectOfType<Manager>();
        autowork = FindObjectOfType<Autowork>();
        //effectTools = FindObjectOfType<Effect_ToolsT2>();
    }

    private void Update()
    {
        clickCounterText.text = manager.myClickCounter.ToString("0");
        dollarsEarnedCounterText.text = manager.dollarsAdded.ToString(manager.dollarsAdded + "$/click");
        autoClickCounterText.text = autowork.value.ToString("+ 1$/" + autowork.value);
    }
}
