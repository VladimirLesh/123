using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelUser : MonoBehaviour
{
    public Text protText, timeText; 


    void Update()
    {
        if (GameManager.GM.isPlay && !GameManager.GM.isDead)
        {
            protText.text = $"{GameManager.GM.ProtCoint}";
            timeText.text = $"{GameManager.GM.Time}";
        }
    }
}
