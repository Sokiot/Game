using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    Text HealthNumber;

    int CurrentHealth = 100;
    const int maxHealth = 100;

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, maxHealth);
        if (CurrentHealth == 0)
        {
            Death();
        }

        HealthNumber.text = CurrentHealth.ToString();
    }

    public void Death()
    {
       
    }
}