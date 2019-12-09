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
    public string ftag;
    
    void Update()
    {        
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
            //CountScore();            
        }
        
        
        if (trig.gameObject.name == "Food")
        {
            ftag = trig.gameObject.tag;            
            playerScore += 10;
            Debug.Log(ftag);


            //go = GameObject.FindGameObjectsWithTag(ftag);
            //switch (ftag)
            //{
            //    case "F1":
            //        for (var i = 0; i < ftag.Length; i++)
            //        {
             //           Destroy(ftag[i]);
             //       }
                    //Destroy(GameObject.FindGameObjectsWithTag(ftag));                    
             //       break;

                

             //   default:
             //       break;
            }
            Destroy(trig.gameObject);
        }


    } 






   // void CountScore()
   // {
    //    playerScore = playerScore + (int)(timeLeft * 2);
    //    Debug.Log(playerScore);        
   // }    
//}