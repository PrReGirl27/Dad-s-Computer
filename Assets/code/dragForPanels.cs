using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dragForPanels : MonoBehaviour, IDragHandler, IPointerDownHandler

{
    Vector3 MouseDragStartPos;
    public static bool canDrag = true;
    public Canvas canvas;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (canDrag == true) // if a button isn't being clicked
        {
            MouseDragStartPos = Input.mousePosition - transform.localPosition;
            Debug.Log("clciked");
            // allows the mouse position and panel position
        }

    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (canDrag == true) // if a button isn't being clicked
        {
        // drags the panel or what ever game object this code is on
            transform.localPosition = Input.mousePosition - MouseDragStartPos / canvas.scaleFactor;
        }


    }






}
