using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    [SerializeField] private GameObject[] freePlatforms;
    [SerializeField] private GameObject[] obstaclePlatforms;
    [SerializeField] private GameObject[] sportPlatforms;
    [SerializeField] private GameObject[] Wells;
    [SerializeField] private Transform PlatformPoint;
    [SerializeField] private Transform WellPoint;
    public int platformCount = 0;
    private Transform lastPlatform = null;
    private Transform lastWellPlatform = null;
    private bool isObstacle = false;

    private void Awake()
    {
        init();
    }

    public void CreatePlatform()
    {
        if (!isObstacle)
        {
            CreateFreePlatform();
            platformCount += 1;
        }
        else
        {
            CreateObstaclePlatform();
            platformCount += 1;
        }
    }

    public void startPlatform()
    {
        Vector3 pos = (lastPlatform == null) ?
               PlatformPoint.position :
               lastPlatform.GetComponent<PlatformController>().endPos.position;
        GameObject res = Instantiate(obstaclePlatforms[0], pos, Quaternion.identity, PlatformPoint);
        lastPlatform = res.transform;
    }

    public void init()
    {
        startPlatform();
        for (int i = 0; i < 7; i++)
        {
            CreateObstaclePlatform();
            CreateWellsPlatform();
        }
    }

    private void CreateFreePlatform ()
    {
        Vector3 pos = (lastPlatform == null) ?
            PlatformPoint.position :
            lastPlatform.GetComponent<PlatformController>().endPos.position;

        int index = Random.Range(0, freePlatforms.Length);
        GameObject res = Instantiate(freePlatforms[index], pos, Quaternion.identity, PlatformPoint);
        lastPlatform = res.transform;
        isObstacle = true;
    }

    private void CreateObstaclePlatform()
    {
        Vector3 pos = (lastPlatform == null) ?
            PlatformPoint.position :
            lastPlatform.GetComponent<PlatformController>().endPos.position;

        int index = Random.Range(1, obstaclePlatforms.Length);
        GameObject res = Instantiate(obstaclePlatforms[index], pos, Quaternion.identity, PlatformPoint);
        lastPlatform = res.transform;
        isObstacle = false;
    }
    private void CreateSportPlatform()
    {
        Vector3 pos = (lastPlatform == null) ?
            PlatformPoint.position :
            lastPlatform.GetComponent<PlatformController>().endPos.position;
        int index = Random.Range(0, sportPlatforms.Length);
        GameObject res = Instantiate(sportPlatforms[index], pos, Quaternion.identity, PlatformPoint);
        lastPlatform = res.transform;
        isObstacle = false;
    }

    public void CreateWellsPlatform()
    {
        Vector3 WellPos = (lastWellPlatform == null) ?
            WellPoint.position :
            lastWellPlatform.GetComponent<PlatformController>().endPos.position;
        int index = Random.Range(0, Wells.Length);
        GameObject resWell = Instantiate(Wells[index], WellPos, Quaternion.identity, WellPoint);
        lastWellPlatform = resWell.transform;
    }
}
