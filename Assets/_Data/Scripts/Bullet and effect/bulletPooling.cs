using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPooling : MonoBehaviour
{
    public static bulletPooling Instance;
    private List<GameObject> BulletPooling = new List<GameObject>();
    private int AmountBullet = 5;
    [SerializeField] private GameObject BulletPool;
    private void Awake()
    {
        if (Instance = null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        for(int i = 0; i<AmountBullet; i++)
        {
            GameObject bullets = Instantiate(this.BulletPool);
            bullets.SetActive(false);
            BulletPooling.Add(bullets);
        }
    }
    public GameObject GetPoolingObject()
    {
        for (int i = 0; i < BulletPooling.Count; i++)
        {
          if(!BulletPool.activeInHierarchy)
            {
                return BulletPooling[i];
            }
        }
        return null;
    }
}
