using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadNewLevelComputer () // load a new scene
    {
        SceneManager.LoadScene("Computer");
    }

    public void LoadNewLevelBeforeyoustart() // load a new scene
    {
        SceneManager.LoadScene("BeforeYouStart"); 
    }

    public void LoadNewLevelMainMenu() // load a new scene
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadNewLevelHowToPlay() // load a new scene
    {
        SceneManager.LoadScene("HowToPlay");
    }

}
