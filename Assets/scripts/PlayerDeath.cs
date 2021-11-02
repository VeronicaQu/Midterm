using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private Rigidbody2D rb;
     [SerializeField] private AudioSource deathSoundEffect;


  private void Start()
  {
      rb = GetComponent<Rigidbody2D>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.gameObject.CompareTag("trap"))
      {
          deathSoundEffect.Play();
          RestartLevel();
      }
  }

  private void RestartLevel()
  {
      //Score.scoreValue = 0;
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

}
