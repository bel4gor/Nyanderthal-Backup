using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrunkDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyProjectile"))
        {
            CrunkHealth crunkHealth = GetComponent<CrunkHealth>();
            if (crunkHealth != null)
            {
                crunkHealth.TakeDamage(1); // Inflicts 1 damage
                Destroy(collision.gameObject); // Destroy the projectile
            }
        }
    }
}
