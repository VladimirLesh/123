using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelSettngs : MonoBehaviour
{
    [SerializeField] private GameObject buttomMenu;
    [SerializeField] private GameObject buttomRestart;
    [SerializeField] private GameObject panel;

    private void Awake()
    {
        //panel.SetActive(false);
    }

    public void ToMenuInLevel()
    {
        if (panel.activeSelf == true)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        } 
    }
    public void HideMenu()
    {
        panel.SetActive(false);
    }
}
