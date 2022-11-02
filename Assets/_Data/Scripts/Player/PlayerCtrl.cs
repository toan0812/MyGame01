using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public static PlayerCtrl instance;
    public PlayerShoot playerShoot;
    public Player_Movement player_Movement;
    public DameReciver dameReciver;
    //public bulletPooling bulletpooling;
   private void Awake()
    {
        if(instance !=null)
        {
            instance = this;
        }
        player_Movement = GetComponent<Player_Movement>();
        playerShoot = GetComponent<PlayerShoot>(); 
        dameReciver = GetComponent<DameReciver>();
    }
}
