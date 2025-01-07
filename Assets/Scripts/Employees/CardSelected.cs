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

    public void SaveInfo(int index)
    {
        auto.value += cards[index].currentCard.autoClick;
        jobMeeting.SetActive(false);
    }
}
