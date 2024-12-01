using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buttonClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        playSound();
        mouseClick.canPlay = false;

    }
    private void playSound()
    { sound.Play(); }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
      mouseClick.canPlay = true;    
    }
}
