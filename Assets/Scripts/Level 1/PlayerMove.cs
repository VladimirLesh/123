using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    public Slide capsCollider;
    public AudioSource audioJump;
    public GameObject man;
    public GameManager GM;
    public Jump JumpClass;
    private Vector3 end_pos;
    private Vector3 ofset = new Vector3(2, 0, 0);
    //private float dist = 2f;
    public bool isMoveSide = false;
    private int line = 0;
  
    void Start()
    {
        man = GetComponent<GameObject>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) ToSlide();
        if (!GM.isDead && GM.isPlay)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (line == 1)
                {
                    return;
                }

                if (!isMoveSide)
                {
                    isMoveSide = true;
                    if (JumpClass.isGrounded(JumpClass.rayLength))
                    {
                        JumpClass.animator.SetTrigger("Right");

                    }
                    StartCoroutine(MoveLeftAndRight());
                    end_pos = transform.position + ofset;
                    line++;
                }
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (line == -1)
                {
                    return;
                }
                if (!isMoveSide)
                {
                    isMoveSide = true;
                    if (JumpClass.isGrounded(JumpClass.rayLength))
                    {
                        JumpClass.animator.SetTrigger("Left");
                    }
                    StartCoroutine(MoveLeftAndRight());
                    end_pos = transform.position - ofset;
                    line--;
                }
            }

            if (isMoveSide)
        {
            StartCoroutine(MoveLeftAndRight());
        }
    }

}

    public IEnumerator MoveLeftAndRight()
    {
        yield return new WaitForEndOfFrame();
        if (!GM.isDead)
        {
            if (isMoveSide)
            {
                transform.position = Vector3.MoveTowards(transform.position, end_pos, 0.3f);
                if ((end_pos - transform.position).magnitude < 0.05f)
                {
                    transform.position = end_pos;
                    isMoveSide = false;
                }
            }
        }
    }

    public void ToLeft()
    {
        if (line == -1)
        {
            return;
        }
        if (!isMoveSide)
        {
            isMoveSide = true;
            audioJump.Play();
            if (JumpClass.isGrounded(JumpClass.rayLength))
            {
                JumpClass.animator.SetTrigger("Left");
            }
            StartCoroutine(MoveLeftAndRight());
            end_pos = transform.position - ofset;
            line--;
        }
    }

    public void ToRight()
    {
        if (line == 1)
        {
            return;
        }

        if (!isMoveSide)
        {
            isMoveSide = true;
            audioJump.Play();
            if (JumpClass.isGrounded(JumpClass.rayLength))
            {
                JumpClass.animator.SetTrigger("Right");
            }
            StartCoroutine(MoveLeftAndRight());
            end_pos = transform.position + ofset;
            line++;
        }
    }

    IEnumerator SlideNow()
    {
        yield return new WaitForEndOfFrame();
        capsCollider.capsuleCollider[0].enabled = false;
        capsCollider.capsuleCollider[1].enabled = true;
        yield return new WaitForSeconds(1f);
        capsCollider.capsuleCollider[0].enabled = true;
        capsCollider.capsuleCollider[1].enabled = false;
    }

    public void ToSlide()
    {
        JumpClass.animator.SetTrigger("Slide");
        StartCoroutine(SlideNow());
    }

    //private void MoveToLeft()
    //{
    //    transform.position = Vector3.Lerp(transform.position, transform.position + )
    //}

    //    void MoveSide(Vector3 endPos)
    //    {
    //        Sequence sequence = DOTween.Sequence();
    //        sequence.Append(transform.DOMove(endPos,1).SetEase(Ease.Linear));
    //        sequence.OnComplete(endMoveSide);
    //    }
    //    void endMoveSide()
    //    {
    //        isMoveSide = false;
    //    }
}
