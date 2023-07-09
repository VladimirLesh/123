using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelSettings : MonoBehaviour
{
    [SerializeField] private GameObject _panelSettings;
    

    public void ToMenuInLevel()
    {
        if(_panelSettings.activeSelf == true)
        {
            _panelSettings.SetActive(false);
        }
        else
        {
            _panelSettings.SetActive(true);
        } 
    }
    public void HideMenu()
    {
        _panelSettings.SetActive(false);
    }
}
