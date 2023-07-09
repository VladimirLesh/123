using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform deltaPos;
    private Vector3 currentCamPos;
    private CamMove camMove;
    private Rigidbody RB;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.isKinematic = true;
        camMove = GetComponent<CamMove>();
        currentCamPos = transform.position - deltaPos.position;
    }

    private void Update()
    {
        transform.position = currentCamPos + deltaPos.position;
        if (GameManager.GM.isDead)
        {
            camMove.enabled = false;
            RB.isKinematic = false;
            RB.useGravity = true;
        }
    }
}

