using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class keypad : MonoBehaviour
{
    public TMP_InputField code;
    public GameObject button1; 
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject enter;
    public GameObject clear;
    public string password = "";

    public GameObject openNew;
    public GameObject closeThis;

    public AudioSource wrong;
    public AudioSource right;

    public void b1()
    {
        code.text = code.text + "1";
    }

    public void b2()
    {
        code.text = code.text + "2";
    }

    public void b3()
    {
        code.text = code.text + "3";
    }

    public void b4()
    {
        code.text = code.text + "4";
    }

    public void b5()
    {
        code.text = code.text + "5";
    }

    public void b6()
    {
        code.text = code.text + "6";
    }

    public void b7()
    {
        code.text = code.text + "7";
    }

    public void b8()
    {
        code.text = code.text + "8";
    }

    public void b9()
    {
        code.text = code.text + "9";
    }

    public void b0()
    {
        code.text = code.text + "0";
    }
    public void eventClear()
    {
        code.text = "";
    }

    public void answer()
    {
        if (code.text == password)
        {
            Debug.Log("correct");
            code.text = "Correct";
            StartCoroutine(RightAnswer(0.5f));
            right.Play();   
        }
        else
        {
          
            code.text = "Incorrect";
            wrong.Play();

            StartCoroutine(ClearTextAfterDelay(0.5f)); // 2 seconds delay
        }
    }

    // Coroutine to wait for a specified time and then clear the text
    IEnumerator ClearTextAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Clear the text after the delay
        code.text = "";
    }
    IEnumerator RightAnswer(float delay)
    {
        
        yield return new WaitForSeconds(delay);

        
        openNew.SetActive(true);
        closeThis.SetActive(false);
        code.text = password;
    }
  
}
// Start is called before the first frame update
