using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
 public static bool canMove;
 public GameObject GameOverM;
 public int Score;
 public Text textScore;
 public Text highScoreText;
 

    void Start () {
        Score = 0;
        textScore.text = Score.ToString();
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Highest Score: " + highScore.ToString();
}
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        canMove = true;
    }
    private void OnTriggerExit2D(Collider2D other) {
        canMove=false;

        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "lose") {
              Destroy(this.gameObject);
              GameOverM.SetActive(true);
              GameOver();
              Time.timeScale = 0;
        }
        if(other.gameObject.tag == "score") {
            Score +=1;
            textScore.text= Score.ToString();
            Destroy(other.gameObject);
        }
    }
    public void GameOver()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
         if (Score > highScore)
        {
              PlayerPrefs.SetInt("HighScore", Score);
            PlayerPrefs.Save();
             highScoreText.text = "Highest Score: " + Score.ToString();
              }
    }
}
