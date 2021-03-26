using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMouvement : MonoBehaviour
{
    public PlayerController controller;
    public Animator animator;
    public float runSpeed = 40f;
    public SpriteRenderer rend;
    

    float horizontalMove = 0f;
    float verticalMove = 0f;
    bool jump = false;
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
       //animator.SetFloat("PlayerSpeed", Mathf.Abs(horizontalMove));
    verticalMove = Input.GetAxisRaw("Vertical")*runSpeed;


    if(horizontalMove > 0)
    {
        rend.flipX = false;
    }
    else if(horizontalMove < 0)
    {
        rend.flipX = true;
    }
    

        animator.SetFloat("x", Mathf.Abs(horizontalMove));
        animator.SetFloat("y",Mathf.Abs(verticalMove));
    }

    
}
