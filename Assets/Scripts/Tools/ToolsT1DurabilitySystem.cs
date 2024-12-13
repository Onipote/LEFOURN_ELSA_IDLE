using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolsT1DurabilitySystem : MonoBehaviour
{
    public ToolsT1Acquisition toolProperties;
    
    public Image shearsDurability, hatchetDurability, merlinDurability, sabersawDurability, logsawDurability, chainsawDurability;
    public int hpMax = 100;
    public float hp1, hp2, hp3, hp4, hp5, hp6;

    private void Start()
    {
        hp1 = hpMax;
        
    }

    void Update()
    {
        if (toolProperties.shearsAcquired == true)
        {
            shearsDurability.fillAmount = hp1 / hpMax;
        }
        
        if (toolProperties.hatchetAcquired == true)
        {
            shearsDurability.fillAmount = hp2 / hpMax;
        }
        
        if (toolProperties.merlinAcquired == true)
        {
            shearsDurability.fillAmount = hp3 / hpMax;
        }
        
        if (toolProperties.sabersawAcquired == true)
        {
            shearsDurability.fillAmount = hp4 / hpMax;
        }
        
        if (toolProperties.logsawAcquired == true)
        {
            shearsDurability.fillAmount = hp5 / hpMax;
        }
        
        if (toolProperties.chainsawAcquired == true)
        {
            shearsDurability.fillAmount = hp6 / hpMax;
        }
    }
}
