using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            NextLevel();
        }
    }
     
      private void NextLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
   }

}
