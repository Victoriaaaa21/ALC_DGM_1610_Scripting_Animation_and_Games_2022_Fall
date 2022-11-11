using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3; 
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //Set current health to max heallth 
        Time.timeScale = 1f;
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount; // Take away a certain amount of health
        Debug.Log("Players Health = "+ currentHealth);

        if(currentHealth <= 0) //Check to see if the player has expired 
        {
            Debug.Log("Player has Died! Game Over!");
            Time.timeScale = 0f;
            Destroy(gameObject,deathDelay);
        }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth) //Check to make sure currentHealth does not exceed max health
        {
            currentHealth = maxHealth;
        }
    }
}
