using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaverDameSender : DameSender

{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            dameReciver.TakeDamage(damage);
            dameReciver.Dead();
        }
    }
}
