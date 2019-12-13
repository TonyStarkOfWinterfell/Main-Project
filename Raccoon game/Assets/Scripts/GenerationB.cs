using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationB : MonoBehaviour
{


    public GameObject thePlatformB;
    public Transform generationPointB;
    public float distanceBetweenB;
    private float platformWidthB;


    // Start is called before the first frame update
    void Start()
    {
        platformWidthB = thePlatformB.GetComponent<BoxCollider2D>().size.x;
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > (generationPointB.position.x))
        {
            Debug.Log(transform.position.x + " " + generationPointB.position.x);
            transform.position = new Vector3(transform.position.x - platformWidthB - distanceBetweenB, transform.position.y, transform.position.z);
            Instantiate(thePlatformB, transform.position, transform.rotation);
        }
    }
}
