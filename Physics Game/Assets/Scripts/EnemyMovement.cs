using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    //Make script that changes transform for X
    // Start is called before the first frame update
    public float speed = 0.2f;
    public GameObject enemy;
    public float moveTime = 5.0f;
    public float resetTime = 2.0f; 
    public bool isMovingRight = true;
    public Rigidbody rb;

    
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        moveTime -= Time.deltaTime;

        if (isMovingRight)
        {
            rb.velocity = transform.right;
        }
        else 
        {
            rb.velocity = -transform.right;
        }

        if (moveTime <= 0) 
        {

            moveTime = 5;
            isMovingRight = !isMovingRight;
                        
        }

     

      //  if (moveTime >= 0)
      //  {
      //     //b.AddForce(Vector3.right * speed); 
      //  }
      //
      //  if(moveTime <= 0 && changeDir == false)
      //  {
      //     //b.AddForce(Vector3.left * speed); 
      //  }
      //
      //  if (moveTime <= 0)
      //  {
      //     //b.AddForce(Vector3.left * speed); 
      //  }
      //
      //  if (moveTime <= -2.0f)
      //  {
      //      moveTime = resetTime;
      //      changeDir = true; 
      //  }
      //
      //  if(moveTime <= 0)
      //  {
      //      changeDir = false; 
      //  }
    }
}
