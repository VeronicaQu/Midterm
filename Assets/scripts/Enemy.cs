using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public BoxCollider2D col;
    public GameObject player;

    void Awake(){
        player = GameObject.Find("Player");
    }

    private void OnTriggerStay2D(Collider2D collision){
        if(collision.CompareTag("attackTrigger") && player.GetComponent<PlayerAttack>().attack == true){
            Destroy(this.gameObject);

        }
         

    }
}
