using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stopButton : MonoBehaviour
{
    
    public void Stop() {
        Time.timeScale = 0;
    }
    public void Play() {
        Time.timeScale = 1;
    }
   public void BackToMenu() {
    
        SceneManager.LoadScene("Menu");
    }
}
