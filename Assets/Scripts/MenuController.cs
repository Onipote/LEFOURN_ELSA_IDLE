using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Manager manager;
    public Autowork autowork;
    
    public GameObject startPanel;
    public GameObject pausePanel;
    public bool isPaused;
    public bool gameWasSaved;
    
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
        if (gameWasSaved)
        {
            LoadGame();   
        }
        startPanel.SetActive(false);
    }
    
    public void Resume()
    {
        pausePanel.SetActive(false);
        isPaused = false;
    }

    public void LoadGame()
    {
        manager.coin = PlayerPrefs.GetFloat("coin");
        manager.myClickCounter = PlayerPrefs.GetInt("myClickCounter");
        manager.dollarsAdded = PlayerPrefs.GetFloat("dollarsAdded");
        manager.clickMultiplier = PlayerPrefs.GetFloat("clickMultiplier");
        autowork.intervalAutoClick = PlayerPrefs.GetFloat("value");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
