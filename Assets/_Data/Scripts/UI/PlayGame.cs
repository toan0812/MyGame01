using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public int index;
    [SerializeField] AudioSource buttonEffect;
    public void Play()
    {
        buttonEffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }

}
