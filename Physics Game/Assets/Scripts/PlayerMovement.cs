using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement; 

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.5f;
    public int score = 0; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Treasure")
        {
            //score++;
            GameManager.Instance.Score++;
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fall")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            //score--;
            GameManager.Instance.Score--;
            Destroy(gameObject);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //BRINGING TO END SCENE IF PLAYER DIES vvvvvvvvv
            //SceneManagement.LoadScene(SceneManager.GetActoveScene().buildIndex + 1); 
        }
    }
}
