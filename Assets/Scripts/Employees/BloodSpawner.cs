using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BloodSpawner : MonoBehaviour
{
    public CardSelected selectedCard;

    public float timeInterval;
    public GameObject blood;
    public GameObject spawner;
    public Transform minLimit;
    public Transform maxLimit;
    public Vector2 pos;

    public int bloodCounter;

    public void Start()
    {
        StartCoroutine(StartJobMeetings());
    }
    public IEnumerator StartJobMeetings()
    {
        yield return new WaitForSeconds(timeInterval);
        while (true)
        {
            spawnBlood();
            yield return new WaitForSeconds(timeInterval);
        }
    }
    
    private void spawnBlood()
    {
        bloodCounter = Random.Range(1, 5);
        
        for (int i = 0; i < bloodCounter; i++)
        {
            float screenX, screenY;
        
            screenX = Random.Range(minLimit.position.x, maxLimit.position.x);
            screenY = Random.Range(minLimit.position.y, maxLimit.position.y);
            pos = new Vector2(screenX, screenY);
        
            Instantiate(blood, pos, Quaternion.identity, spawner.transform);
        }
    }

    public void Remove()
    {
        bloodCounter--;
        
        if (bloodCounter == 0)
        {
            selectedCard.jobMeeting.SetActive(true);
        }
    }
}
