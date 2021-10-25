using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    private static music musicManagerInstance;
    void Awake()
    {
           DontDestroyOnLoad(this);

           if(musicManagerInstance == null){
               musicManagerInstance = this;
           }
           else{
               Destroy(gameObject);
           }
    }
    
}
