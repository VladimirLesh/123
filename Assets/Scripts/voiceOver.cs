using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voiceOver : MonoBehaviour
{
    private AudioSource[] klickOnbuttom;

    private void Start()
    {
        klickOnbuttom = FindObjectsOfType<AudioSource>();
    }

    public void KlickOnButtom()
    {
        klickOnbuttom[0].Play();
    }
}
