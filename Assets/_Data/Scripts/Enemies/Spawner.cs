using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    // spawn enemies in 1 scene
    [Header("Enemy")]
    public float MaxCrap;
    public GameObject craps;
    public Transform SpawnPoint;
    private List<GameObject> Enemies = new List<GameObject>();
    public GameObject MiniBoss;
    public GameObject Boss;
    public GameObject Enemyspawner;
    [Header("Time Spawn Enemy")]
    public float TimeSpawner = 1.5f;
    public float TimeStartSpawner = 0;
    //[Header("Audio")]
    //public AudioSource audioEffect;
    private void Update()
    {
        TimeStartSpawner += Time.deltaTime;
        SpawnerEnemies();
        spawnerBoss();
    }
    protected virtual void  SpawnerEnemies()
    {
        //TimeStartSpawner += Time.deltaTime;
        if (TimeStartSpawner < TimeSpawner) return;
        TimeStartSpawner = 0;
        if (MaxCrap <= 0) return;
        //audioEffect.Play();
        GameObject Craps = Instantiate(this.craps);
        Craps.transform.position = this.SpawnPoint.position;
        Craps.transform.parent = gameObject.transform;
        MaxCrap--;
        
        this.Enemies.Add(Craps);
        

    }

    protected virtual void spawnerBoss()
    {
       
        if(MaxCrap <= 0 && MiniBoss.GetComponent<MiniBossDameReciver>().MaxHealth>0)
        {
            MiniBoss.SetActive(true);
            //MiniBoss.transform.position = SpawnPoint.position;
            Boss.SetActive(true);
            Enemyspawner.SetActive(false);
        }

    }


}
