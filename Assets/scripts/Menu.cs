using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
public void Play() {
    SceneManager.LoadScene("GamePlay");
    Time.timeScale = 1;
}
public void Exit() {
    Application.Quit();
}
}
