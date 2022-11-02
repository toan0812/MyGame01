using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniBossMovement : MonoBehaviour
{

    public float MiniBossSpeed ;
    private Animator animator;

  
    private void Start()
    {

        animator = GetComponent<Animator>();
        animator.SetBool("isMoving", true);
    }
    private void Update()
    { 
        MiniBossMove();

    }

    protected virtual void MiniBossMove()
    {
        transform.Translate(Vector3.right * MiniBossSpeed * Time.deltaTime);
    }



}
