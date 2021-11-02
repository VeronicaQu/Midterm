using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public bool attack = false;

    private float attackTimer = 0;
    private float attackCd = 1.0f;
    
    public GameObject AttackTrigger;
    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        AttackTrigger = GameObject.Find("AttackTrigger");
    }

    void Update()
    {
        if(Input.GetKey("f") && !attack)
        {
            anim.SetTrigger("attack");
            attackTimer = attackCd;
            attack = true;
        }

        if(attack)
        {
            if(attackTimer > 0)
            {
                attackTimer -=Time.deltaTime;
            }
            else
            {
                attack = false;

            }
        }

        
    }

}
