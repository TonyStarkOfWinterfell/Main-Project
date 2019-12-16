using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class Player_Score : MonoBehaviour
{
    private int Pick = 0;
    private int Drop = 0;

    public float timeLeft = 40;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public string ftag;
    public GameObject[] go;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        if (Drop >= 7)
        {
            SceneManager.LoadScene("Ending");
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Finish")
        {
            CountScore();
        }


        if (trig.gameObject.name == "Food")
        {
            ftag = trig.gameObject.tag;
            playerScore += 100;
            Pick += 1;


            go = GameObject.FindGameObjectsWithTag(ftag);
            switch (ftag)
            {
                case "F1":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }
                    
                    break;

                case "F2":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F3":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F4":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F5":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F6":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F7":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;



                default:
                    break;
            }            
        }
                                    





        void CountScore()
        {
            if (Pick > 0)
            {
                playerScore = playerScore + (int)(timeLeft * Pick * 5);
            }            
            Drop = Drop + Pick;
            Pick = 0;            
        }
    }

}