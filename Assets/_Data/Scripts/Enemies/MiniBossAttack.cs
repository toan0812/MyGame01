using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossAttack : MonoBehaviour
{
    public float timer;
    public float timebtwattack;
    private Animator animator;
    private miniBossMovement minibossMovement;


    public Vector3 Offset;
    public float attackRange = 1f;
    public LayerMask attackMask;
    public int MiniBossDame = 15;

    public void attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * Offset.x;
        pos += transform.up * Offset.y;
        Collider2D collider =Physics2D.OverlapCircle(pos, attackRange,attackMask);
        if(collider!=null)
        {
            collider.GetComponent<DameReciver>().TakeDamage(MiniBossDame);

        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
        minibossMovement = GetComponent<miniBossMovement>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            MiniBossattack();

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        minibossMovement.MiniBossSpeed = 2f;
    }

    public void MiniBossattack()
    {
        minibossMovement.MiniBossSpeed = 0f;
        if (timer >= timebtwattack)
        {
            animator.SetTrigger("attack");
            timer = 0f;
        }
    }
}
