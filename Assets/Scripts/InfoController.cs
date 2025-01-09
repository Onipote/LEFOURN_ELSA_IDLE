using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoController : MonoBehaviour
{
    public TextMeshProUGUI info;
    public Achievements[] list;
    
    void Start()
    {
        HideInfo();
    }

    public void DisplayInfo(string infoText,float duration=8f)
    {
        info.text = infoText;
        Invoke(nameof(HideInfo), duration);
    }
    
    public void HideInfo()
    {
        info.enabled = false;
    }
}
