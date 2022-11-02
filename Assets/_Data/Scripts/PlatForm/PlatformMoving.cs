using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    // khoi tao bien toc do cho platform va diem bat dau va diem ket thuc
    public float Speed_Platform;
    public int StartPoint;
    public Transform[] Points;
    private int i= 0;// tao 1 bien i bat ky

    public float timer = 0f;
    public float timeBtwFly;

    private void Start()
    {
        transform.position = Points[StartPoint].position;// gan vi tri dau tien = 0
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, Points[i].position) < 0.02f) // kiem tra neu nhu vi tri cua platform da den diem thu i hay chua
        {
            i++;// neu da den thi tang i len 1 
            if (i == Points.Length)// neu nhu platform da den diem ket thuc thi reset lai i
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Points[i].position, Speed_Platform * Time.deltaTime);
    }

   
}
