using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class DamageController : MonoBehaviour
{
    [SerializeField] private float fishDamage;
    [SerializeField] private HealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - fishDamage;
        healthController.UpdateHealth();
        this.gameObject.SetActive(false);
    }
}
