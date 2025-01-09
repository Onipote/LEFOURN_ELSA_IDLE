using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    public bool isPaused;

    private void Start()
    {
        startPanel.SetActive(true);
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            pausePanel.SetActive(true);
            isPaused = true;
        }
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
    }
    
    public void Resume()
    {
        pausePanel.SetActive(false);
        isPaused = false;
    }
}
