using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPickup : MonoBehaviour
{
    //public int fishValue = 1;

    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("fish"))
        {
            Destroy(gameObject);
        }
    }
}
