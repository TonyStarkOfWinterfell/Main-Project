using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Score : MonoBehaviour
{

    public float timeLeft = 120;
    public int playerScore = 0;
   
    void Update()
    {
        Debug.Log(playerScore);
        timeLeft -= Time.deltaTime;    
        if (timeLeft <0.1f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnTriggerEnter2D (Collider2D trig)
    {
        CountScore();
    }

    void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log(playerScore);
    }

}