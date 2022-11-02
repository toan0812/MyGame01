using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDamesender : MonoBehaviour
{
    public int damage = 20;
    public int damePowerup = 150; 
    private EnemiesDameReciver enemiesDame;

    private void Awake()
    {
        enemiesDame = GetComponent<EnemiesDameReciver>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemiesDame.TakeDamage(damage);
            enemiesDame.Dead();           
        }
        else if(collision.gameObject.CompareTag("powerup"))
        {
            enemiesDame.TakeDamage(damePowerup);
            enemiesDame.Dead();
        }
        
    }
}
