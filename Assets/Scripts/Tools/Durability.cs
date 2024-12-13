using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Durability : MonoBehaviour
{
    public Image healthbar;
    public float maxHp = 100;
    public float hp;
    public float hpLossInterval;

    private void Start()
    {
        hp = maxHp;
    }

    void Update()
    {
            healthbar.fillAmount = hp / maxHp;
    }

    public IEnumerator ShearsDurability()
    {
            while (hp > 0)
            {
                hp = hp - 1;
                yield return new WaitForSeconds(hpLossInterval);
            }
    }
}
