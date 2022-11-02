using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaverDameReciver: DameReciver
{
    public bool checkDead = false;
    public void SaverDead()
    {
        if(MaxHealth <= 0)
        {
            Debug.Log("dead");
            gameObject.SetActive(false);
            checkDead = true;   
        }
    }

}
