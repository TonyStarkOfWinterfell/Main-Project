using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip AppleClip;
    public AudioClip JumpClip;
    public AudioClip DeathClip;
    public AudioSource MusicSource;
    



    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = AppleClip;
    }

    // Update is called once per frame
    void Update()
    {
        //MusicSource.clip = AppleClip;

        if (Input.GetButtonDown("Jump"))
        {
            MusicSource.clip = JumpClip;
            MusicSource.Play();            
        }        
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Pickapple")
        {
            MusicSource.Play();
        }
    }
}
