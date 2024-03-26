using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerMavi : MonoBehaviour
{
    public int score;

    public Text ScoreText;

    public AudioSource AudioSource;

    public GameObject pausescreen;

    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
        AudioSource.Play(); 
    }

 
    public void UpdateScore ()
    {
        score++;
        ScoreText.text = score.ToString();
        AudioSource.Play ();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(5);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(1);
    }

    public void oyunudurdur()
    {
         Time.timeScale = 0f;
         pausescreen.SetActive(true);
        
    }

    public void resumebutton()
    {
          Time.timeScale = 1f;
          pausescreen.SetActive(false);
    }


}
