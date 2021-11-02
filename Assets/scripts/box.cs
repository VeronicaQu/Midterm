using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
   private Animator anim;

   void Start(){
       anim = GetComponent<Animator>();
   }

   public void Smash()
   {
       anim.SetBool("smash", true);
       StartCoroutine(breakCo());
   }

   IEnumerator breakCo()
   {
       yield return new WaitForSeconds(.5f);
    
       this.gameObject.SetActive(false);
   }
}
