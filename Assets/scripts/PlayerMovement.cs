using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
    private BoxCollider2D coll;
    public float speed = .05f;
    public Animator anim;
    private SpriteRenderer sprite;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    bool canDoubleJump;

    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    
    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);            
        }
        
         if (dirX > 0f)
         {
             anim.SetBool("walk", true);
             sprite.flipX = false;
            
         }
         else if(dirX < 0f)
         {
             anim.SetBool("walk", true);
             sprite.flipX = true;
         }
         else
         {
             anim.SetBool("walk", false);
         }
        
         if (Input.GetKey(KeyCode.LeftArrow)){

            transform.Translate(Vector2.right * -1 * speed);
        }
        
        if (Input.GetKey(KeyCode.RightArrow)){

            transform.Translate(Vector2.right * speed);

             
    }
}

private bool IsGrounded()
{
  return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
} 

}
