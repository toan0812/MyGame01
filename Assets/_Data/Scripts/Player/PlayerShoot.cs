using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Animator animator;
    public BulletDeSpawn Bullet;
    public powerUP specialBullet;//ky nang dac biet
    public Transform ShootPoint;
    public AudioSource audioEffect;
    //thoi gian spawn
    public float timer = 0;
    public float timerToMana = 0;
    public float timebtwshoot = 0.5f;
    public float timespawnSkill = 1f;
    // Mana Bar
    public ManaBar manabar;
    public float Maxmana = 100f;
    public float currentMana;
    public float ManaUsed= 1f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        currentMana = Maxmana;
        manabar.SetMaxMana(Maxmana);
    }
 
    private void Update()
    {
        PlayerShooting();
        timer += Time.deltaTime;
        UpMana();
    }
    public void PlayerShooting()
    {
       

        if (Input.GetButtonDown("Fire1") && timer < timebtwshoot && Maxmana > 0)
        {
            Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
            animator.SetInteger("state", 3);
            Maxmana -= ManaUsed;
            currentMana = Maxmana;
            manabar.setMana(currentMana);
            audioEffect.Play();
            
        }
       
        else if (Input.GetButtonDown("Fire2") && timer < timespawnSkill && Maxmana > 0)
        {
            Instantiate(specialBullet, ShootPoint.position, ShootPoint.rotation);
            animator.SetInteger("state", 3);
            Maxmana -= 30;
            currentMana = Maxmana;
            manabar.setMana(currentMana);
            audioEffect.Play();

        }
        timer = 0;

    }
    public void UpMana()
    {
        timerToMana += Time.deltaTime;
        if (timerToMana >= timespawnSkill && currentMana < 100)
        {
            currentMana += 0.5f;
            Maxmana = currentMana;
            manabar.setMana(currentMana);
            timerToMana = 0;
        }
    }





}
