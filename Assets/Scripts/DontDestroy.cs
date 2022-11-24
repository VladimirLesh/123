using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    [Header("Tags")]
    [SerializeField] private string musicTag;

    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag(this.musicTag);

        if (obj.Length >= 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = this.musicTag;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 0)
        {
            gameObject.GetComponent<AudioSource>().mute = true;
        }
        else gameObject.GetComponent<AudioSource>().mute = false;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
