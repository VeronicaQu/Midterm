using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    

   
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Energy"))
        {
            Score.scoreValue += 1;
            Destroy(collision.gameObject);
            
            

        }
    }
   
}
