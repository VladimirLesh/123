using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeComtorller : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public PlayerMove PM;
    public Jump JumpClass;

    public void OnDrag(PointerEventData eventData)
    {
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > (eventData.delta.y))
        {
            // Swipe Right
            if (eventData.delta.x > 0)
            {
                PM.ToRight();
            }
            // Swipe Left
            else if (eventData.delta.x < 0)
            {
                PM.ToLeft();
            }
            else if (eventData.delta.y < 0) PM.ToSlide();

        }
        else if (Mathf.Abs(eventData.delta.y) > (Mathf.Abs(eventData.delta.x)))
        {
            if (Mathf.Abs(eventData.delta.y) > 0)
            {
                //Swipe Up
                if (JumpClass.isGrounded(JumpClass.rayLength))
                {
                    JumpClass.JumpNow();
                }
                //else
                //{
                //    PM.ToSlide();
                //}
            }            
        }
        else if (Mathf.Abs(eventData.delta.y) < 0) JumpClass.JumpNow();

        if (PM.isMoveSide)
        {
            StartCoroutine(PM.MoveLeftAndRight());
        }

    }
}
