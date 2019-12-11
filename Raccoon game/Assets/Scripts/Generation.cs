using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{


    public GameObject thePlatform;
    public Transform generationPointF;
    public Transform generationPointB;
    public float distanceBetween;

    private float platformWidth;
    private float platformWidthBack;
    //private float platformWidth;

    private GameObject player;
    private Player_Move playerMove;









    // Start is called before the first frame update
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        player = GameObject.FindGameObjectWithTag("Player");
        playerMove = player.GetComponent<Player_Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < (generationPointF.position.x) && playerMove.moveX > 0.0f)
        {
            Debug.Log(transform.position.x + " " + generationPointF.position.x);
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, transform.position, transform.rotation);

        }


        if (transform.position.x > (generationPointB.position.x) && playerMove.moveX < 0.0f)
        {
            Debug.Log(transform.position.x + " " + generationPointB.position.x);
            transform.position = new Vector3(transform.position.x + platformWidth - distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, transform.position, transform.rotation);
        }






    }
}
