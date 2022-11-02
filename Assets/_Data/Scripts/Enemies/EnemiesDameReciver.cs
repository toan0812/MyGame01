using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDameReciver : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public GameObject Effect;
    public AudioSource audioEffect;
    private void Awake()
    {
        CurrentHealth = MaxHealth;

    }
    public virtual void TakeDamage(int damage)
    {
        MaxHealth -= damage;
        CurrentHealth = MaxHealth;
    }

    public virtual void Dead()
    {
        if (MaxHealth <= 0)
        {
            GameObject effect = Instantiate(Effect, transform.position, Quaternion.identity);
            audioEffect.Play();
            Destroy(effect,0.5f);          
            Destroy(gameObject);

        }
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Saver") )
        {
            MaxHealth = 0;
            Dead();
           
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            MaxHealth = 0;
            Dead();
        }    
    }

}
