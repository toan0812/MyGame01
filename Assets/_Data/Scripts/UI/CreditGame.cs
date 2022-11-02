using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditGame : MonoBehaviour
{
    public GameObject creditManager;
    [SerializeField] AudioSource buttonEffect;

    public void Credit()
    {
        buttonEffect.Play();
        creditManager.SetActive(true);
    }
    public void Back()
    {
        buttonEffect.Play();
        creditManager.SetActive(false);
    }
}
