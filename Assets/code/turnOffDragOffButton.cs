using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class turnOffDragOffButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{

// this is for the off buttons

    public GameObject panel;
    public void OnPointerDown(PointerEventData eventData)
    {
    
        drag.canDrag = false;

        Debug.Log("clciked");
    }

    public void OnPointerUp(PointerEventData eventData)

    {
        drag.canDrag = true;
        Debug.Log("notclciked");
    }





    public void OnDrag(PointerEventData eventData)
    {
        drag.canDrag = false;
       

        Debug.Log("clciked");
    }

    private void Update()
    {
        if (panel.activeSelf == false)
        {
            drag.canDrag = true;
        }
    }
}
