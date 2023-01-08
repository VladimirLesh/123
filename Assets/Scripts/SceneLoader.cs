using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ReloadScene(int sceneIndex)
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene()
    {
        SceneTransition.SwitchToScene("Level 1");
    }

    public void LoadStartScene()
    {
        SceneTransition.SwitchToScene("Start");
        StaticBoolChangies.isScaleOn = false;
    }
}
