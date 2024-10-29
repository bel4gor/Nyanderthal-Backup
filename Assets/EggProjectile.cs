using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggProjectile : MonoBehaviour
{
    public float speed = 10f; // Speed of the egg projectile
    public float lifetime = 20f; // Time before the egg destroys itself

    private void Start()
    {
        // Destroy the egg after its lifetime
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        // Move the egg projectile forward
        transform.Translate(Vector2.down* speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the egg hits the player
        if (collision.CompareTag("Player"))
        {
            // Optionally, call a method on the player to deal damage
         //   collision.GetComponent<PlayerHealth>().TakeDamage(1); // Example method
        }
        
    }
}
