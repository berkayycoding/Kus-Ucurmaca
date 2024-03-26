using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerKirmizi : MonoBehaviour
{
    public int score;

    public Text ScoreText;

    public AudioSource AudioSource;

    public bool oyundurdumu = false;
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
        SceneManager.LoadScene(4);
    }
    public void MenuGame()
    {
        SceneManager.LoadScene(1);
    }

    public void oyunudurdur()
    {
        if (oyundurdumu == false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;  
        }
        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
    }

}
