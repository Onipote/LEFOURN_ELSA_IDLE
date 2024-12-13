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
    public float hp;

    private void Start()
    {
        hp = hpMax;
    }

    void Update()
    {
        if (toolProperties.shearsAcquired == true)
        {
            shearsDurability.fillAmount = hp / hpMax;
            StartCoroutine(ShearsDurability());
        }
    }

    public IEnumerator ShearsDurability()
    {
        while (hp > 0)
        {
            yield return new WaitForSeconds(toolProperties.shearsTime);
            hp = hp - 1;
        }
    }
}
