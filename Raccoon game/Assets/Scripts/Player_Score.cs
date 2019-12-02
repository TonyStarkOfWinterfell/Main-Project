using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    public float timeLeft = 120;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
   
    void Update()
    {
        Debug.Log(playerScore);
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        if (timeLeft <0.1f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnTriggerEnter2D (Collider2D trig)
    {
        if (trig.gameObject.name == "LevelCP")
        {
            CountScore();            
        }
        if (trig.gameObject.name == "Food (1)")
        {
            playerScore += 10;
            Destroy(trig.gameObject);
        }


    } 

    void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log(playerScore);        
    }


}