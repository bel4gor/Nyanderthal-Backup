using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure you have the right namespace for TextMeshPro

public class FoodCounter : MonoBehaviour
{
    public int foodCount = 0; // Counter to track food items collected
    public TextMeshProUGUI foodCounterText; // Reference to the TextMeshProUGUI component

    void Start()
    {
        // Initialize the UI text with the starting count
        UpdateFoodCounterUI();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object is tagged as 'food'
        if (collision.CompareTag("food"))
        {
            foodCount++; // Increase the counter
            UpdateFoodCounterUI(); // Update the UI text
            Debug.Log("Food collected! Total food: " + foodCount);

            // Destroy the food item once collected
            Destroy(collision.gameObject);
        }
    }

    // Method to update the UI text
    void UpdateFoodCounterUI()
    {
        foodCounterText.text = "Food: " + foodCount;
    }
}
