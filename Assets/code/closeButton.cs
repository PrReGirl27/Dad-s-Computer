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
// closes the panel
        }

    }

    public void OnPointerUp(PointerEventData eventData)

    {
        drag.canDrag = true;
        Debug.Log("notclciked");
    }

// when ever the close button is clicked it will close the panel; if the player tries to drag the close button nothing will happen



    public void OnDrag(PointerEventData eventData)
    {
        drag.canDrag = false;

        Debug.Log("clciked");
    }
}
