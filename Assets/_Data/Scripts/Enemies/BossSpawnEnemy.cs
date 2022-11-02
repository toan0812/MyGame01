using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnEnemy : MonoBehaviour
{
    [Header("Enemy")]
    public GameObject Enemies;
    public Transform Spawpos;
    private GameObject MiniBoss;
    public bool isSpawning;

    [Header("Timer")]
    public float timeSpawner = 0f;
    public float timeBtwSpawner = 2f;

    [Header("Animation")]
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        MiniBoss = GameObject.Find("miniBoss");
    }

    private void Update()
    {
        timeSpawner += Time.deltaTime;
        BossSpawn();
    }

    protected virtual  void BossSpawn()
    {
        
        if (timeSpawner < timeBtwSpawner) return;
        timeSpawner = 0;
        if (MiniBoss.GetComponent<MiniBossDameReciver>().CheckDead == false)
        {
            isSpawning = true;
            GameObject OC = Instantiate(this.Enemies);
            animator.SetTrigger("attack");
            OC.transform.position = this.Spawpos.position;
        }
        else if (MiniBoss.GetComponent<MiniBossDameReciver>().CheckDead == true)
        {
            isSpawning =false;
        }
       

      
    }




}
