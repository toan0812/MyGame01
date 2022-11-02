using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabWalks : MonoBehaviour
{
    public float CrabSpeed = 3f;
   
    private void Update()
    {
        MoveFoward();
    }
    protected virtual void MoveFoward()
    {
        transform.Translate(Vector3.right * CrabSpeed * Time.deltaTime);

    }
}
