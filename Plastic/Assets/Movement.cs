using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 500f;
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce((Vector3.left * speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down * speed * Time.deltaTime);
    }
}
