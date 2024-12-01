using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    public AudioSource sound;
    public static bool canPlay = true;
  
    void Update()
    {
        if (canPlay)
        {
if (Input.GetMouseButtonDown(0) == true)
        {
            playSound();
        }
       
        }
 
       
    }

    private void playSound()
    { sound.Play(); }
    private void stopSound() { sound.Stop();}
   
}
