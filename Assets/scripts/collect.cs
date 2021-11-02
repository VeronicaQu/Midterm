using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
     [SerializeField] private AudioSource collectSoundEffect;


   
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Energy"))
        {
            collectSoundEffect.Play();
            Score.scoreValue += 1;
            Destroy(collision.gameObject);
            
            

        }
    }
   
}
