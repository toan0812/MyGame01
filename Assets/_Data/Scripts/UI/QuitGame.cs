using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField] AudioSource buttonEffect;

    public void Quit()
    {
        buttonEffect.Play();
        Debug.Log("Quit Game");
        Application.Quit();
    }

}
