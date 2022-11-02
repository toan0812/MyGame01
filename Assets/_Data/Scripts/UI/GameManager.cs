using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //static public GameManager instance;
    private GameObject Player;
    public GameObject MainBoss;
    private GameObject Saver;

    private void Start()
    {
        Player = GameObject.Find("PlayerModel");
       
        Saver = GameObject.Find("Saver 2");
        
    }
    //private void Awake()
    //{
    //    instance = this;
    //}

    private void Update()
    {
        CheckGameOver();
    }
    public void CheckGameOver()
    {
        if (Player.GetComponent<DameReciver>().MaxHealth <= 0 || Saver.GetComponent<DameReciver>().MaxHealth <= 0 || MainBoss.GetComponent<MiniBossDameReciver>().MaxHealth <= 0)
        {
            restartGame();
        }
       

    }
  
    public void restartGame()
    {
        SceneManager.LoadScene("End Game");
    }
}
  
  
   


