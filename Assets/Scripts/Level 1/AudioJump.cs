using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioJump : MonoBehaviour
{
    [SerializeField] AudioSource _sound;

    private void Awake()
    {
        _sound = GetComponent<AudioSource>();
    }

    public void JumpSound() => _sound.Play();
    
}
