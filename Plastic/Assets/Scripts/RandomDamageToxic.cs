using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RandomDamageToxic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var HealthController = collision.gameObject.GetComponent<Health>();
            System.Random rand = new System.Random();

            if (rand.Next(0, 2) == 0)
            {
                HealthController.TakeDamage(15);
            }

            else
            {
                HealthController.TakeDamage(0);
            }

            this.gameObject.SetActive(false);
        }
    }
}
