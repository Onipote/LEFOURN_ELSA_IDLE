using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JobMeetingEvent : MonoBehaviour
{
    public WorkingForMoney coin;
    [SerializeField] private GameObject _jobText;
    [SerializeField] private GameObject _employeeCards;
    [SerializeField] private int timer = 0;
    
    /*public IEnumerator StartJobMeeting()
    {
        yield return new WaitForSeconds(5); //se declenche 1s apres avoir 500 coins
        DisplayJobText(); //affiche le texte pendant 3s
        DisplayJobPanel(); //affiche le panel Employee cards
    }*/
    private void Update()
    {
        StartCoroutine(DisplayJobText());
    }

    private IEnumerator DisplayJobText()
    {
        if (coin.coin == 5)
        {
            yield return new WaitForSeconds(0.5f);
            _jobText.SetActive(true);
            yield return new WaitForSeconds(0.8f);
            _jobText.SetActive(false);
            timer++;
        }

        timer = 0;
    }
    private void DisplayJobPanel()
    {
        _employeeCards.SetActive(true);
    }
}
