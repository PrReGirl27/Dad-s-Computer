using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class password2 : MonoBehaviour
{
    public TMP_InputField code;
    public string password = "";
    public GameObject enter;
    // Start is called before the first frame update


    public GameObject openNew;

    public AudioSource wrong;
    public AudioSource right;

    void Start()
    {





    }

    // Update is called once per frame
    public void answer()
    {
        if (code.text == password)
        {
           //if the password is correct
            Debug.Log("correct");
            code.text = "Correct";
            StartCoroutine(RightAnswer(0.5f)); // 2 seconds delay
            right.Play(); // play "correct" sound
        }
        else
        {
//if the password is wrong
            code.text = "Incorrect";
            wrong.Play(); // play wrong sound
          

            StartCoroutine(ClearTextAfterDelay(0.5f)); // 2 seconds delay; afterwads the text will clear
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

        yield return new WaitForSeconds(delay); // wait for 2 second for the text field to say correct
        openNew.SetActive(true); // open a new panel
        code.text = password; // put the password into the text field

    }

}
