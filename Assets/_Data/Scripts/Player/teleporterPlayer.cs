using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterPlayer : MonoBehaviour
{
    [SerializeField] private GameObject telelported1;
    [SerializeField] private GameObject telelportedlv1;
    //[SerializeField] private GameObject telelported2;
    //[SerializeField] private GameObject telelportedlv2;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("teleporter1"))
        {
            gameObject.transform.position = telelportedlv1.transform.position;
        }
        //else if (collision.gameObject.CompareTag("teleporter2"))
        //{
        //    gameObject.transform.position = telelportedlv2.transform.position;
        //}
        else if (collision.gameObject.CompareTag("teleporterlv1"))
        {
            gameObject.transform.position = telelported1.transform.position;
        }
        //else if (collision.gameObject.CompareTag("teleporterlv2"))
        //{
        //    gameObject.transform.position = telelported2.transform.position;
        //}

    }
}
