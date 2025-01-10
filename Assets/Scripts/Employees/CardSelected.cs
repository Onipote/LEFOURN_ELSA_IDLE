using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardSelected : MonoBehaviour
{
    public Autowork auto;
    public List<CardReader> cards;
    public GameObject jobMeeting;
    public bool autoworkStart = false;
    
    public void SaveInfo(int index)
    {
        auto.intervalAutoClick = cards[index].currentCard.autoClick;
        autoworkStart = true;
        for (int i = 0; i < 3; i++)
        {
            cards[i].RandomizeCards();
        }
        jobMeeting.SetActive(false);
    }
}
