using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadNewLevelComputer ()
    {
        SceneManager.LoadScene("Computer");
    }

    public void LoadNewLevelBeforeyoustart()
    {
        SceneManager.LoadScene("BeforeYouStart");
    }

    public void LoadNewLevelMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadNewLevelHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

}
