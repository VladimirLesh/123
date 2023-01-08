using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneTransition : MonoBehaviour
{
    [SerializeField] private Text _loadingPrecentage;
    [SerializeField] private Image _loadingProgressBar;
    
    private Animator _animator;
    private static SceneTransition _instance;
    private AsyncOperation _loadingSceneOperation;
    private static bool _shouldPlayOpeningAnimation = false;

    public static void SwitchToScene(string sceneName)
    {
        _instance._animator.SetTrigger("SceneClose");
        _instance._loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        _instance._loadingSceneOperation.allowSceneActivation = false;
    }
    private void Start()
    {
        _instance = this;
        _animator = GetComponent<Animator>();

        if (_shouldPlayOpeningAnimation) _animator.SetTrigger("SceneOpen");
    }

    private void Update()
    {
        if (_loadingSceneOperation != null)
        {
            _loadingPrecentage.text = Mathf.RoundToInt(_loadingSceneOperation.progress * 100) + "%";
            _loadingProgressBar.fillAmount = _loadingSceneOperation.progress;
        }
    }

    private void OnAnimationOver()
    {
        _shouldPlayOpeningAnimation = true;
        _loadingSceneOperation.allowSceneActivation = true;
    }
}
