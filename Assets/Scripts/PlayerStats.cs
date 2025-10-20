using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Heal(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("»ç¸Á");
        }
        Debug.Log("ÇöÀç Ã¼¼† : " + currentHealth);
    }
    public void TakeDamage(int amount)
    {
        if(amount > 0)
        {
            currentHealth -= amount;
        }
        else
        {
            currentHealth += amount;
        }

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("»ç¸Á");
        }
        Debug.Log("ÇöÀç Ã¼·Â : " + currentHealth);
    }
}
