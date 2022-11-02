using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameSender : MonoBehaviour
{
    //private Animator m_Animator;
    public int damage = 10;
    public DameReciver dameReciver;
    private void Start()
    {
        dameReciver = GetComponent<DameReciver>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            dameReciver.TakeDamage(damage);
            dameReciver.Dead();
        }
      
    }
  

}
