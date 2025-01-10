using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



   

    public class idk : MonoBehaviour, IPointerDownHandler,  IPointerUpHandler, IDragHandler

     {


    public void OnPointerDown(PointerEventData eventData)
        {
       drag.canDrag = false;
          // if a button is being clicked, the panel can't be dragged 
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
    // if a button is being dragged, the panel can't be dragged
        drag.canDrag = false;

        Debug.Log("clciked");
    }
}
