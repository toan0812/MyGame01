using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlowPlayer : MonoBehaviour
{
    public GameObject Player;
    private void Awake()
    {
        Player = GameObject.Find("PlayerModel");
    }
    private void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
        
    }
}
