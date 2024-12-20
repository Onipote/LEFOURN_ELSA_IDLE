using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new_employee", menuName = "EmployeeCards", order = 0)]
public class EmployeeCard : ScriptableObject
{
    public string cardName;
    public EmployeeType status;
    public Sprite picture;
    public int autoClick;
    public string description;
}
