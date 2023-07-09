using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    [SerializeField] private Animator animator;
    public bool isPlay = false;
    public bool isDead = false;
    public float Time = 0f;
    public int ProtCoint = 0;

    private void Awake()
    {
        if (GameManager.GM != null)
        {
            Destroy(gameObject);
            return;
        }
        GameManager.GM = this;
    }

    void Update()
    {
        if (isPlay && !isDead) Time += UnityEngine.Time.deltaTime;
    }

    public void StartRun()
    {
        isPlay = true;
        animator.SetTrigger("Run");
    }
}
