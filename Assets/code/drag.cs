using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class drag : MonoBehaviour, IDragHandler, IPointerDownHandler

{
    Vector3 MouseDragStartPos;
    public static bool canDrag = true;
    public Canvas canvas;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canDrag == true)
        {
            MouseDragStartPos = Input.mousePosition - transform.localPosition;
            Debug.Log("clciked");
        }

    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (canDrag == true)
        {
            transform.localPosition = Input.mousePosition - MouseDragStartPos / canvas.scaleFactor;
        }


    }






}
