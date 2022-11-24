using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanels : MonoBehaviour
{
    [SerializeField] private GameObject panelChooselevel;
    [SerializeField] private GameObject panelStartPanel;
    [SerializeField] private GameObject panelSettings;

    void Start()
    {
        panelChooselevel.SetActive(false);
        panelStartPanel.SetActive(true);
        panelSettings.SetActive(false);
    }

    public void fromStartToChoose() // from rirst panel to second
    {
        panelChooselevel.SetActive(true);
        panelStartPanel.SetActive(false);
        panelSettings.SetActive(false);
    }
    public void ToStartMenu() // from rirst panel to second
    {
        panelChooselevel.SetActive(false);
        panelStartPanel.SetActive(true);
        panelSettings.SetActive(false);
    }
    public void ToMenu()
    {
        panelChooselevel.SetActive(false);
        panelStartPanel.SetActive(false);
        panelSettings.SetActive(true);
    }

    public void StartMaximumHeightGame()
    {
        StaticBoolChangies.isScaleOn = true;
    }
}
