using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StorePanelsController : MonoBehaviour
{
    [SerializeField] private GameObject _upgTab;
    [SerializeField] private GameObject _tlsTab;

    private void Start()
    {
        _tlsTab.SetActive(true);
        _upgTab.SetActive(false);
    }

    public void OpenUpgTab()
    {
        _upgTab.SetActive(true);
        _tlsTab.SetActive(false);
    }

    public void OpenTlsTab()
    {
        _tlsTab.SetActive(true);
        _upgTab.SetActive(false);
    }
}
