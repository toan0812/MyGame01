using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [Header("Timer")]
    public float timer;
    public float timebtwattack;

    [Header("GetComponent")]
    private Animator animator;
    private BossMovement bossMovement;

    [Header("collider")]
    public Vector3 Offset;
    public float attackRange = 1f;
    public LayerMask attackMask;

    [Header("Damage")]
    public int BossDame = 25;

    public void attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * Offset.x;
        pos += transform.up * Offset.y;
        Collider2D collider = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (collider != null)
        {
            collider.GetComponent<DameReciver>().TakeDamage(BossDame);

        }
    }

    private void Start()
    {
      
        animator = GetComponent<Animator>();
        bossMovement = GetComponent<BossMovement>();
    }
    
    private void Update()
    {
        timer += Time.deltaTime;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Bossattack();

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Saver"))
        {
            Bossattack();

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        bossMovement.BossSpeed = 1.5f;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        bossMovement.BossSpeed = 1.5f;
    }
    public void Bossattack()
    {
        bossMovement.BossSpeed = 0f;
        if (timer >= timebtwattack)
        {
            animator.SetTrigger("attack");
            timer = 0f;
        }
    }

}
