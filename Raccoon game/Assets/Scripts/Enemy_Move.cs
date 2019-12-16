using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    public int current;
    public bool FacingRight = true;

    public float CurrentXPos;

    private void Start()
    {
        CurrentXPos = gameObject.transform.position.x;
    }


    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);            
        }
        else current = (current + 1) % target.Length;





                
        if (gameObject.transform.position.x > CurrentXPos)
        {            
            FlipPlayer();
            CurrentXPos = gameObject.transform.position.x;
        }


        if (gameObject.transform.position.x < CurrentXPos)
        {            
            FlipPlayer();
            CurrentXPos = gameObject.transform.position.x;
        }
    }

    void FlipPlayer()
    {
        if(gameObject.transform.position.x > CurrentXPos && FacingRight == true)
        {
            FacingRight = !FacingRight;
            Vector2 localScale = gameObject.transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }        
        else if (gameObject.transform.position.x < CurrentXPos && FacingRight == false)
            {
                FacingRight = !FacingRight;
                Vector2 localScale = gameObject.transform.localScale;
                localScale.x *= -1;
                transform.localScale = localScale;
            }
    }

}
