using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameReciver : MonoBehaviour
{
    public int MaxHealth ;
    public int CurrentHealth;
    public HealthBar HealthBar;
    public GameObject Effect;
    public AudioSource AudioSource;
    public bool CheckDead = false;
    private void Awake()
    {

        CurrentHealth= MaxHealth ;
        HealthBar.SetMaxHealth(MaxHealth);
    }
    public virtual void TakeDamage(int damage)
    {
        MaxHealth -= damage;
        CurrentHealth = MaxHealth;
        HealthBar.SetHealth(CurrentHealth);
    }
    private void Update()
    {

        Dead();
    }
    public virtual void Dead()
    {
        if (MaxHealth <= 0)
        {
            CheckDead = true;
            GameObject effect = Instantiate(Effect, transform.position, Quaternion.identity);
            Destroy(effect,0.5f);
            AudioSource.Play();
            gameObject.SetActive(false);

        }
    }
}
