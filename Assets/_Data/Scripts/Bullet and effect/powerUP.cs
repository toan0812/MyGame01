using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUP : MonoBehaviour
{

    public float ForceSpeed = 8f;
    private Rigidbody2D rb;
    private GameObject player;
    public GameObject Effect;
    private void Awake()
    {
        player = GameObject.Find("PlayerModel");
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        bulletMoveleft();
        Destroy(gameObject, 3f);

    }
    public void bulletMoveleft()
    {
        rb.velocity = transform.right * direction() * ForceSpeed;
    }
    public int direction()
    {
        if (player.transform.localScale.x < 0f)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }
}
