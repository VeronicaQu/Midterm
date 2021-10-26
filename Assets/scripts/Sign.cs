using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRanger;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) && playerInRanger)
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                }else{
                    dialogBox.SetActive(true);
                    dialogText.text = dialog;
                }
            }
        }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
           playerInRanger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
           playerInRanger = false;
           dialogBox.SetActive(false);
        }
    }
}

