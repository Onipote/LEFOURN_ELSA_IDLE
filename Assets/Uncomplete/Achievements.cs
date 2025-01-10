using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new_achievement", menuName = "Achievements", order = 0)]
public class Achievements : ScriptableObject
{
    public string type;
    public string achDescription;
    public Sprite icon;
}
