using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

public class CardReader : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText, statusText, autoclickText, descriptionText;
    [SerializeField] private Image cardPicture;
    
    public EmployeeCard currentCard;
    [SerializeField] public EmployeeCard[] candidateList;

    private void Start()
    {
        RandomizeCards();
    }

    public void RandomizeCards()
    {
        ReadCard(candidateList[Random.Range(0, candidateList.Length)]);
    }

    public void ReadCard(EmployeeCard newCard)
    {
        
        currentCard = newCard;
        nameText.text = currentCard.cardName;
        statusText.text = currentCard.status.ToString();
        cardPicture.sprite = currentCard.picture;
        
        descriptionText.text = currentCard.description;
        
        switch (currentCard.status)
        {
            case EmployeeType.Retired:
                currentCard.autoClick = Random.Range(0.4f, 0.5f);
                break;

            case EmployeeType.Worker:
                currentCard.autoClick = Random.Range(0.3f, 0.4f);
                break;

            case EmployeeType.Student:
                currentCard.autoClick = Random.Range(0.2f, 0.3f);
                break;

            case EmployeeType.Kid:
                currentCard.autoClick = Random.Range(0.1f, 0.2f);
                break;
        }
        autoclickText.text = "Autoclick interval : " + currentCard.autoClick.ToString("0.00");
    }
}
