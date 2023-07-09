using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    public static Man instance;

    private float scale;

    private void Start()
    {
        if (Man.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Man.instance = this;
    }
}
