using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;
public class TriggerJobMeeting : MonoBehaviour
{
    public CardReader reader;
    public BloodSpawner spawner;

    private void Start()
    {
        spawner = FindObjectOfType<BloodSpawner>();
    }

    public void Clean()
    {
        spawner.Remove();
        Destroy(gameObject);
    }
}