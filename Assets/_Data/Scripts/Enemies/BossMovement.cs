using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    [Header("Is Movement")]
    private Animator animator;
    public float BossSpeed ;
    private BossSpawnEnemy bossSpawnEnemy;
    public GameObject shield;
    private void Start()
    {
        animator = GetComponent<Animator>();
        bossSpawnEnemy = GetComponent<BossSpawnEnemy>();

    }

    private void Update()
    {
        BossMove();

    }

    protected virtual void BossMove()
    {
        if(bossSpawnEnemy.isSpawning == false)
        {
            shield.SetActive(false);
            transform.Translate(Vector3.right * BossSpeed * Time.deltaTime);
            animator.SetBool("isMoving", true);

        }
        
    }

}
