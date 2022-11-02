using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject MiniBoss;
   

    private void Awake()
    {
        MiniBoss = GameObject.Find("miniBoss");

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Saver"))
        {
            MiniBoss.GetComponent<MiniBossAttack>().MiniBossattack();
        }
    }
    
}
