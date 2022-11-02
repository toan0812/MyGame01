using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossDamesender : MonoBehaviour
{
    public int damage = 20;
    public int damePowerup = 150;
    private MiniBossDameReciver miniBossDameReciver;

    private void Awake()
    {
        miniBossDameReciver = GetComponent<MiniBossDameReciver>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            miniBossDameReciver.TakeDamage(damage);
            miniBossDameReciver.Dead();
        }
        else if (collision.gameObject.CompareTag("powerup"))
        {
            miniBossDameReciver.TakeDamage(damePowerup);
            miniBossDameReciver.Dead();
        }

    }
}
