using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ReloadScene(int SceneIndex)
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        StaticBoolChangies.isScaleOn = false;
    }
}
