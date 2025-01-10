using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class passwordFinal : MonoBehaviour // this is for the final password of the game; this had to be made in order to load a new sense
{
    public TMP_InputField code;
    public string password = "Hi"; // fake password; public makes it editable in the unity engine
    public GameObject enter;
    public AudioSource wrong; ew
    public AudioSource right;
    // Start is called before the first frame update


  

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
            right.Play();
        }
        else
        {
//if the password is wrong
            code.text = "Incorrect";
            wrong.Play();

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

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Final");

// loads the last sense of the game
        code.text = password;
    }
}
