using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpOnObstacle : MonoBehaviour
{
    public AudioSource AudioProt;
    public RegDollController RegDollController;
    public Jump jump;

    private Animator animator;
    private Transform Man;

    void Start()
    {
        animator = GetComponent<Animator>();
        Man = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            RegDollController.RegDollKinematicIsOff();
            animator.enabled = false;
            GameManager.GM.isDead = true;
        }       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Prot"))
        {
            AudioProt.Play();

            if (StaticBoolChangies.isScaleOn)
            {
                Vector3 scale = Man.transform.localScale;
                Man.localScale = scale * 1.01f;
                jump.rayLength *= 1.01f;
            }
        }
    }
}