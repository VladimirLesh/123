using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Man man;
    public float jumpSpeed = 11;
    public float rayLength;

    public Animator animator;
    private Rigidbody Rb;
    private CapsuleCollider Cc;
    public AudioSource audioJump;

    void Start()
    {
        rayLength = 0.2f;
        Rb = GetComponent<Rigidbody>();
        Cc = GetComponent<CapsuleCollider>();
    }

    public bool isGrounded(float ray)
    {
        return Physics.Raycast(transform.position, Vector3.down, ray);
    }

    void Update()
    {
        if(GameManager.GM.isPlay)
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (isGrounded(rayLength))
                {
                    Rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
                    animator.SetTrigger("Jump");
                }
            }
    }

    private void FixedUpdate()
    {
        
        // Гравитация
        Rb.AddForce(new Vector3(0, Physics.gravity.y * 3, 0), ForceMode.Acceleration);        
    }

    public void JumpNow()
    {
        Rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
        animator.SetTrigger("Jump");
        audioJump.Play();
    }
}
