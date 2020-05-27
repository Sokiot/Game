using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPicker : MonoBehaviour
{
    private float fish = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "fish")
        {
            Destroy(other.gameObject);
        }
    }
}
