using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class Player_Score : MonoBehaviour
{
    private Vector3 offscreen;
    private Vector3 characterPos;
    public GameObject character;
    public GameObject FoodTrail;
    private int FD = 0;
       
    private int Pick = 0;
    private int Drop = 0;

    public float timeLeft = 40;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public string ftag;
    public GameObject[] go;


    private void Awake()
    {        
        offscreen = FoodTrail.transform.position;        
    }


    void Update()
    {
        characterPos = character.transform.position;
        timeLeft -= Time.deltaTime;
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);



        if(Pick == 1 && FD == 0)
        {
            FoodTrail.transform.position = characterPos;
            FD = 1;
        }
        else if(Pick != 1 && FD == 0)
        {
            FoodTrail.transform.position = offscreen;
        }

        if(FoodTrail.transform.position.x < character.transform.position.x - 3)
        {
            FoodTrail.transform.position =  new Vector3( character.transform.position.x - 3, FoodTrail.transform.position.y, FoodTrail.transform.position.z);
        }




        if (Drop >= 7)
        {
            SceneManager.LoadScene("Ending");
        }
    }




    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Finish")
        {
            FD = 0;
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