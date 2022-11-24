using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public CapsuleCollider[] capsuleCollider;

    private void Start()
    {
        capsuleCollider = GetComponents<CapsuleCollider>();
    }
}
