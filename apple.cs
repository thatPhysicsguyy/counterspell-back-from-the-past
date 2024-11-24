using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject clonePrefab; // Reference to the clone prefab

    private void OnTriggerEnter2D(Collider2D other)
    {
        // When the player collides with the apple
        if (other.CompareTag("Player"))
        {
            // Spawn the clone immediately at the apple's position
            Instantiate(clonePrefab, new Vector3(-5, -2, 0), Quaternion.identity);

            // Destroy the apple once it is collected
            Destroy(gameObject);

            Debug.Log("Apple collected! Clone spawned immediately.");
        }
    }
}