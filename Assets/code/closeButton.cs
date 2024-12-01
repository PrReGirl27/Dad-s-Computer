using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class closeButton : MonoBehaviour, IDragHandler, IPointerDownHandler


{
    public GameObject panel;
    bool active;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (active == false)
        {

            panel.SetActive(true);
            active = true;
        }
        else
        {
            panel.SetActive(false);
            active = false;

        }

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
}
