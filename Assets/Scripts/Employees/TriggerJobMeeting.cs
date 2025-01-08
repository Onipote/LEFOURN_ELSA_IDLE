using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TriggerJobMeeting : MonoBehaviour
{
    public GameObject blood;
    
    public void Clean()
    {
        Destroy(blood);
    }
}