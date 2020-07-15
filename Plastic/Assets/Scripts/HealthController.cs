using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //I will update the code as i go along and I want the UI to update with it.

public class HealthController : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private Text healthText;

    private void Start()
    {
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        healthText.text = playerHealth.ToString("0");

    }
}
