using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public RectTransform cloudTransform; // Reference to the RectTransform of the UI cloud
    public float speed = 50f; // Speed at which the cloud moves

    void Start()
    {
        // Optionally, you can initialize the cloudTransform here if it's not already assigned
        if (cloudTransform == null)
        {
            cloudTransform = GetComponent<RectTransform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the cloud horizontally by adjusting its anchored position
        cloudTransform.anchoredPosition += new Vector2(speed * Time.deltaTime, 0f);

        // Optionally, reset the cloud's position if it goes off-screen (example for left to right movement)
        if (cloudTransform.anchoredPosition.x > Screen.width)
        {
            cloudTransform.anchoredPosition = new Vector2(-Screen.width, cloudTransform.anchoredPosition.y);
        }
    }

    // This method is called when the cloud's collider enters another trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the cloud has collided with the boundary (you can tag the boundary for specificity)
        if (other.CompareTag("Boundary"))
        {
            // Destroy the cloud game object when it hits the boundary
            Destroy(gameObject);
        }
    }
}
