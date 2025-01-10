using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoController : MonoBehaviour
{
    public TextMeshProUGUI achUnlocked, achDescription;
    public Image icon;
    
    public Achievements currentInfo;
    public Achievements[] achList;
    
    public void DisplayInfo()
    {
        achUnlocked.text = currentInfo.type;
        achDescription.text = currentInfo.achDescription;
        icon.sprite = currentInfo.icon;
    }
}
