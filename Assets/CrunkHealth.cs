using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Needed for using UI components
using UnityEngine.SceneManagement;

public class CrunkHealth : MonoBehaviour
{
    public int health = 3; // Total health (3 lives)
    public Image[] pawLifeImages; // Array to hold the PawLife images

    private void Start()
    {
        UpdateHealthUI(); // Initialize the UI at the start
    }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        health -= damage; // Decrease health by damage amount
        Debug.Log("Crunk health: " + health);
        UpdateHealthUI(); // Update the UI after taking damage

        if (health <= 0)
        {
            GameOver(); // Call GameOver when health reaches zero
        }
    }

    // Method to update the health UI
    private void UpdateHealthUI()
    {
        for (int i = 0; i < pawLifeImages.Length; i++)
        {
            // Enable or disable the paw images based on current health
            pawLifeImages[i].gameObject.SetActive(i < health);
        }
    }

    // Method to handle game over logic
    private void GameOver()
    {
        SceneManager.LoadScene("GameOver"); 
    }
}