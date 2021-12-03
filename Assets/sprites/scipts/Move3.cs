using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer spitee;

    Vector3 TargetPosition;
    Vector3 TowardsTarget;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
             rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            
        }
        
        else if(Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            
        }
        
        else 
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }   

        if(Input.GetKey("w"))
        {
            rb2d.velocity = new Vector3(rb2d.velocity.x, speed);
        }
        else if(Input.GetKey("s"))
        {
            rb2d.velocity = new Vector3(rb2d.velocity.x, -speed);
        }
        
        else 
        {
            rb2d.velocity = new Vector3(rb2d.velocity.x, 0);

        } 
         
         if(Input.GetKey("f"))
        {
          
            anim.SetInteger("play3",1);
        }
        else 
        {
            anim.SetInteger("play3",0);

        } 

        if(Input.GetKey("g"))
        {
           
            anim.SetInteger("play3.1",1);
         }
         
         else 
        {
            anim.SetInteger("play3.1",0);

        } 
    }
}
