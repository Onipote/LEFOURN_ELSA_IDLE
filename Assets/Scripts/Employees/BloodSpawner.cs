using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BloodSpawner : MonoBehaviour
{
    public GameObject blood;
    public GameObject spawner;
    public Transform minLimit;
    public Transform maxLimit;
    public Vector2 pos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnBlood();
        }
    }

    private void spawnBlood()
    {
        float screenX, screenY;
        
        screenX = Random.Range(minLimit.position.x, maxLimit.position.x);
        screenY = Random.Range(minLimit.position.y, maxLimit.position.y);
        pos = new Vector2(screenX, screenY);
        
        Instantiate(blood, pos, Quaternion.identity, spawner.transform);
    }
}
