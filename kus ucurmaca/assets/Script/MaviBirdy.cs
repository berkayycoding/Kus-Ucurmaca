using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaviBirdy : MonoBehaviour
{
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManagerMavi ManagerGame2;
    public GameObject DeathScreen;
    public AudioSource AudioSource;
  

    private void Start()
    {
        Time.timeScale = 1;
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        //týklamayý al
        if (Input.GetMouseButtonDown(0))
        {
            //havada kuþu sýçrat    
            rb2D.velocity = Vector2.up * velocity;
            AudioSource.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            ManagerGame2.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
           
        }
    }

}
