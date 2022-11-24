using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartRunIE());
    }

    IEnumerator StartRunIE()
    {
        yield return new WaitForSeconds(3);
        GameManager.GM.StartRun();
    }
}
