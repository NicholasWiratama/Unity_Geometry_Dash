using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D io;
    [SerializeField] private AudioSource DeathSoundEffect;

  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            SceneManager.LoadScene("Lose");
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Win();
            SceneManager.LoadScene("Win");
        }
    }

    private void Die()
    {
        DeathSoundEffect.Play();
        // io.bodyType = RigidbodyType2D.Static;
       
    }

    void Win()
    {

    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.CompareTag("")){
    //     }
    // }
}
