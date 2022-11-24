using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public Transform endPos;

    void Start()
    {
        WorldController.instance.OnPlatformMovement += TryDelAndAddPlatform;
    }

    private void TryDelAndAddPlatform()
    {
        if (transform.position.z < WorldController.instance.minZ)
        {
            if (gameObject.CompareTag("Platform"))
            {
                WorldController.instance.worldBuilder.CreatePlatform();
            }
            else if (gameObject.CompareTag("Well"))
            {
                WorldController.instance.worldBuilder.CreateWellsPlatform();
            }
            Destroy(gameObject);
        }
    }

    private void OnDestroy() 
    {
        WorldController.instance.OnPlatformMovement -= TryDelAndAddPlatform;
    }
}
