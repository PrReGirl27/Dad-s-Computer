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
    public TMP_InputField code; // where the numbers will appear
    public GameObject button1; // each button on the keypad
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

    public GameObject openNew; // the new panel that will be opened if the passwords is correct
    public GameObject closeThis; // the keypad that will close if the password is correct

    public AudioSource wrong;
    public AudioSource right;

    public void b1() // when each button is clicked it will display that number
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
    public void eventClearTheText()
    {
        code.text = "";
    }

    public void answer()
    {
        if (code.text == password)
        {
        //if the password is correct
            Debug.Log("correct");
            code.text = "Correct";
            StartCoroutine(RightAnswer(0.5f)); // 2 seconds delay
            right.Play();   
        }
        else
        {
         // if the password is wrong 
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

        // if the password is correct then it will open a new panel, put in the password, and close the keypad
        openNew.SetActive(true);
        closeThis.SetActive(false);
        code.text = password;
    }
  
}
