using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class password3 : MonoBehaviour
{
    public TMP_InputField code;
    public string password = "Hi"; // fake password; public makes it editable in the unity engine
    public GameObject enter;
    public AudioSource wrong;
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
        SceneManager.LoadScene("Final");


        code.text = password;
    }
}
