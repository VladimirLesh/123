using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public float speed = 7f;
    public WorldBuilder worldBuilder;
    public float minZ = -20;
    public GameManager GM;
    public delegate void TryToDelAndAddPlatform();
    public event TryToDelAndAddPlatform OnPlatformMovement;
    public static WorldController instance;

    private void Awake()
    {
        if (WorldController.instance != null)
        {
            Destroy(gameObject);
            return;
        }
        WorldController.instance = this;
    }

    void Start()
    {
        StartCoroutine(OnPlatformMovementCarutine());
        StartCoroutine(SpeedUp());
    }
    
    void Update()
    {
        if (GM.isPlay)
            if (!GM.isDead) transform.position -= Vector3.forward * speed * Time.deltaTime;
        if (GM.isDead)
        {
            StopCoroutine(SpeedUp());
        }
    }

    IEnumerator OnPlatformMovementCarutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (OnPlatformMovement != null)
            {
                OnPlatformMovement();
            }
        }
    }

    IEnumerator SpeedUp()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            speed += 1;
         
        }      
    }
}