using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEngine : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
    {

        SceneManager.LoadScene("Level 1");

    }

    public void Credits()
    {

        SceneManager.LoadScene("Credits");

    }

    public void Exit()
    {

        Application.Quit();

    }

    public void ReturnTheMenu()
    {
        SceneManager.LoadScene("Demo 02");      
    }

}
