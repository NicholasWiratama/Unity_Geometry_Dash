using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour

{
    public GameObject GameOverPanel;
    public Text Wintext; 
    private CharacterController controller;
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource DeathSoundEffect;


    //private Rigidbody2D playerRb;
    //


    private void Start()
    {
        //rb.isKinematic = false;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        //playerRb = GetComponent();

        //playerRb.isKinematic = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            SceneManager.LoadScene("Lose");
        }

        if (collision.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene("Win");
        }

    }

    private void Die()
    {
        //playerRb.isKinematic = true;
        //stop player movement
        DeathSoundEffect.Play();
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
        Movement.CurrentSpeed = 0;

    }


 
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


