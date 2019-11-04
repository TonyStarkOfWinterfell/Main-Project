using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Score : MonoBehaviour
{

    public float timeLeft = 120;
    public int playerscore = 0;
   

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;    
        if (timeLeft <0.1f)
        {

        }
    }
}
