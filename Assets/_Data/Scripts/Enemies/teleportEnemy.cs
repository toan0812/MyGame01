using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportEnemy : MonoBehaviour
{
    public GameObject Leveruplever1;
    //public GameObject Leveruplever2;
    private void Awake()
    {
        Leveruplever1 = GameObject.Find("positionTelePorted 1");
        //Leveruplever2 = GameObject.Find("BlackHole lever up 2");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("teleporter1"))
        {
            gameObject.transform.position = Leveruplever1.transform.position;
        }
      //else if (collision.gameObject.CompareTag("teleporter2"))
      //  {
      //      gameObject.transform.position = Leveruplever2.transform.position;
      //  }

    }


}
