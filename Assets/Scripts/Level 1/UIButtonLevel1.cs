using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonLevel1 : MonoBehaviour
{
    [SerializeField] private Button buttonRestart;
    [SerializeField] private Button buttonMenu;

    void Start()
    {
        buttonRestart.gameObject.SetActive(false);
        buttonMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        if (GameManager.GM.isDead)
        {
            ButtomSetActive();
        }
        else
        {
            ButtomSetActiveFalse();
        }
    }

    public void ButtomSetActive()
    {
        buttonRestart.gameObject.SetActive(true);
        buttonMenu.gameObject.SetActive(true);
    }
    public void ButtomSetActiveFalse()
    {
        buttonRestart.gameObject.SetActive(false);
        buttonMenu.gameObject.SetActive(false);
    }
}
