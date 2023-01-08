using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelDebug : MonoBehaviour
{
    public GameManager GM;
    public Text SpeedText, ScaleText, platformText, timeText;
    public WorldController WC;
    public WorldBuilder WB;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedText.text = $"{WC.speed}";
        platformText.text = $"{WB.platformCount}";
        timeText.text = $"{GM.time}";
    }
}
