using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTAC : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Coll" + collision);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER" + other);
    }
}
