using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PterylSpawner : MonoBehaviour
{
    public GameObject eggPrefab; // Reference to the Egg prefab
    public float spawnTime; // Current spawn time
    public float minSpawnTime; // Minimum time between spawns
    public float maxSpawnTime; // Maximum time between spawns

    private void Start()
    {
        // Start the egg spawning coroutine
        StartCoroutine(SpawnEggs());
    }

    private IEnumerator SpawnEggs()
    {
        // Initialize spawnTime
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

        while (true) // Infinite loop
        {
            // Decrease spawnTime by the time passed since last frame
            spawnTime -= Time.deltaTime;

            if (spawnTime <= 0)
            {
                // Create an instance of the egg projectile
                Instantiate(eggPrefab, transform.position, Quaternion.identity);
                // Reset the spawn time with a new random value
                spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            }

            // Yield execution until the next frame
            yield return null; // This allows Unity to update
        }
    }
}
