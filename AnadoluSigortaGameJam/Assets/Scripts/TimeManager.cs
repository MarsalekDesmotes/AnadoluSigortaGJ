using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;
    public bool level1, level2, level3, level4;
    public AudioSource patlamaEffekti;
    public IEnumerator SlowMotion()
    {

        float time = 0f;

        /*float counterTime = 0f;
        while (counterTime < 0.22f)
        {
            counterTime += Time.deltaTime;
            yield return null;
        }
        */

        while (time < 0.2f)
        {

            Time.timeScale = slowdownFactor;
            Time.fixedDeltaTime = Time.timeScale * .02f;
            time += Time.deltaTime;
       
            yield return null;
        }

        Time.fixedDeltaTime = 0.02f;
        Time.timeScale = 1f;
        //Oyunu tekrar baslat 
        if (level1)
        {
                SceneManager.LoadScene("Level 1");
        }
        if (level2)
        {
            SceneManager.LoadScene("Level 2");
        }
        if (level3)
        {
            SceneManager.LoadScene("Level 3");
        }
        if (level4)
        {
            SceneManager.LoadScene("Level 4");
        }

    }

   

    public void slowMotionEffectCall()
    {   
        StartCoroutine(SlowMotion());
        patlamaEffekti.Play();
    
    }

}
