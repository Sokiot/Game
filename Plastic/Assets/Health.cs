using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] life;
    public Sprite Heart;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < life.Length; i++)
        {
            if (i < health)
            {
                life[i].sprite = Heart;
                health = health - 1;
            }

            if (i < numOfHearts)
            {
                life[i].enabled = true;
            }
            else
            {
                life[i].enabled = false;
            }
        }
    }
}