using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // tao bien di chuyen cho nhan vat
    [SerializeField] private float Player_MoveSpeed = 300f;
    [SerializeField] private float Jump_Force = 7f;
    [SerializeField] private float horizontal;


    // tao bien kiem tra huong cua nhan vat
    bool FacingRight = false;
    //bool duck = false;


    // Kiem tra khi nhay 
    bool IsGrouded = false;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private float CheckRadius;


    //Khai bao bien Animation va rigidbody2d
    private Animator animator;
    private Rigidbody2D rigidbody2d;
    private enum MovementState {idle,Standing,Running,RunShooting,Hurt,Duck,Jump};
    private MovementState State;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        IsGrouded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, layerMask);
        PlayerMovement();
       
    }
    private void Update()
    {
        PlayerJump();
        UpdateAnimation();
        //PlayerDuck();
    }

    protected virtual void PlayerMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rigidbody2d.velocity = new Vector2(horizontal * Player_MoveSpeed * Time.fixedDeltaTime, rigidbody2d.velocity.y);
        if(FacingRight == true && horizontal <0 )
        {
            flip();
        }
        if(FacingRight == false && horizontal >0)
        {
            flip();
        }
    }
    protected virtual void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && IsGrouded == true)
        {
            //rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, Jump_Force);
            rigidbody2d.AddForce(Vector3.up*Jump_Force , ForceMode2D.Impulse);
        }
    }
    protected virtual void PlayerDrop()
    {
        if(transform.position.y < -5)
        {
            //player dead();
        }
    }
    protected virtual void flip()
    {
        FacingRight =! FacingRight;
        Vector3 Scale = transform.localScale;
        Scale.x = Scale.x * -1;
        transform.localScale = Scale;
    }
    //protected virtual void PlayerDuck()
    //{
    //    if (Input.GetButtonDown("Duck"))
    //    {
    //        duck = true;
    //    }
    //    else if (Input.GetButtonUp("Duck"))
    //    {
    //        duck = false;
    //    }
    //}
    protected virtual void UpdateAnimation()
    {
        if(horizontal > 0||horizontal<0)
        {
            State = MovementState.RunShooting;
        }
        if(horizontal == 0)
        {
            State = MovementState.Standing;
        }
        if (IsGrouded == false)
        {
            State = MovementState.Jump;
        }
        //if(duck == true)
        //{
            
        //    State = MovementState.Duck;
        //}
        animator.SetInteger("state", (int)State);
    }

}
