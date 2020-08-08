using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    //Bounds Area;
    private bool moveLeft = true;
    private float moveTime = 7f;
    private float vRange = 0.001f;

    void Start()
    {
        vRange = Random.Range(-0.001f, 0.001f);
    }


    void Update()
    {
        moveTime -= Time.deltaTime;

        if (moveTime < 0)
        {
            moveTime = Random.Range(6f, 8f);
            moveLeft = !moveLeft;
            vRange = Random.Range(-0.001f, 0.001f);

            if (!moveLeft)
            {
                GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            }
        }

        if (moveLeft)
        {
            GetComponent<Transform>().position += new Vector3(-0.02f, vRange, 0);
        }
        else
        {
            GetComponent<Transform>().position += new Vector3(0.02f, vRange, 0);
        }

    }
}
