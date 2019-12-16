using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    private int current;

    public bool facingRight = true;
    



    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;



        //if (moveX < 0.0f && facingRight == false)
        //{
        //    FlipPlayer();
        //}
        //else if (moveX > 0.0f && facingRight == true)
        //{
        //    FlipPlayer();
        //}
    }

    //void FlipPlayer()
    //{
    //    facingRight = !facingRight;
    //    Vector2 localScale = gameObject.transform.localScale;
    //    localScale.x *= -1;
    //    transform.localScale = localScale;
    //}

}
