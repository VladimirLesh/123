using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegDollController : MonoBehaviour
{
    public List<Rigidbody> GetRigidbodies = new List<Rigidbody>();

    void Start()
    {
        RegDollKinematicIsOn();
    }

    public void RegDollKinematicIsOn()
    {
        foreach (var item in GetRigidbodies)
        {
            item.isKinematic = true;
            
        }
    }
    public void RegDollKinematicIsOff()
    {
        foreach (var item in GetRigidbodies)
        {
            item.isKinematic = false;
        }
    }
}
