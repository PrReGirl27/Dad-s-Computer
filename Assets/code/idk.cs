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
}
