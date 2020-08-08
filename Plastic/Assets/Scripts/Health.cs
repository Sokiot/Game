using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    Text HealthNumber;

    int CurrentHealth = 100;
    public Image GameOver;
    //The maxHealth variable had const at the start.
    //I have changed it to a normal int variable because when the Seagull reached 0 health
    //The seagull could still have its health increased when eating a fish.
    //I did not want the number to increase after it hit 0.
    int maxHealth = 100;

    public void Start()
    {
        //GameOver = GameObject.FindWithTag("GameOver");
        //GameOver.GetComponent<Image>().enabled = false; //GameOver image does not appear at the start of the game.
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, maxHealth);

        if (CurrentHealth == 0)
        {
            //Death();
            maxHealth = 0;
            //GameOver.GetComponent<Image>().enabled = true;// GameOver image appears when the seagull reaches 0 health.
            SceneManager.LoadScene("Quit");
        }

        HealthNumber.text = CurrentHealth.ToString();
    }

    /*public void Death()
    {
        GameOver.layer = 2;
    }*/
}