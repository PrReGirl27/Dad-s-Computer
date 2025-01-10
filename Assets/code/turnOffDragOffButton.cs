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
    // if a button is being clicked, the panel can't be dragged 
        drag.canDrag = false;

        Debug.Log("clciked");
    }

    public void OnPointerUp(PointerEventData eventData)

    {
     // if a button is not being clicked, the panel can be dragged
        drag.canDrag = true;
        Debug.Log("notclciked");
    }





    public void OnDrag(PointerEventData eventData)
    {
        drag.canDrag = false;
       
 // if a button is being dragged, the panel can't be dragged
        Debug.Log("clciked");
    }

    private void Update()
    {
        if (panel.activeSelf == false)
        {
        // if the panel is closed, the panel can be dragged
            drag.canDrag = true;
        }
    }
}
