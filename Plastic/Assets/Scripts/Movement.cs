using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    //[SerializeField]
    public float speed = 500f; //was 500f at the start
    //private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //direction = Vector2.up;
    }
    void Update()
    {
        //GetInput();
        //Move();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce((Vector3.left * speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down * speed * Time.deltaTime);
    }

    /*public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }*/
}
