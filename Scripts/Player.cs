using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins;

   public Rigidbody2D rb;
   public int movespeed;
   public int jumppower;
   public Transform groundCheck;
   public float groundCheckRadius;
   public LayerMask whatIsGround;

   public float startx;

   public float starty;

   public bool moveLeft;
   public bool moveRight;
   private bool onGround;
   private Animator anim;

   private int facing = 1;

   void Start()
   {
    rb = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
    facing = 1;
   }

   void FixedUpdate()
   {
    onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
   }

   private void Update() {
    
     if (moveLeft || Input.GetKey(KeyCode.LeftArrow))
        {
        rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        anim.SetBool("Walking", true);
        if(facing == 1)
        {
            transform.localScale = new Vector3(-0.04f, 0.04f, 0.04f);
            facing = 0;
        }
        } 
        else if (moveRight || Input.GetKey(KeyCode.RightArrow))
        {
        rb.velocity = new Vector2(movespeed, rb.velocity.y);
        anim.SetBool("Walking", true);
        if(facing == 0)
        {
            transform.localScale = new Vector3(0.04f, 0.04f, 0.04f);
            facing = 1;
        }
        } else
        {
        anim.SetBool("Walking", false);
        }
        if (Input.GetKey(KeyCode.Space) )
        {
            jump();
        }


       
    }

     public void jump()
        {
            if(onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumppower);
            }
        }

    
   
     
}
