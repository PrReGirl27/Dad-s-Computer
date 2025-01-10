using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openClose : MonoBehaviour
{
    public GameObject panel;
    bool active;

    public void OpenAndClose()
    { 
    if (active==false)
        {
        // if the panel is closed then the button clicked will open the panel
            gameObject.transform.gameObject.SetActive(true);
            active = true;
        }
    else  {
     // if the panel is opened then the button clicked will close the panel
            gameObject.transform.gameObject.SetActive(false);
            active = false;
           
        }

        
    }
}
