using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton pattern
    public GameObject clonePrefab;      // Clone prefab
    public Transform cloneParent;       // Optional: organize clones under a parent object

    private void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnAppleCollected(Vector2 spawnPosition)
    {
        // Spawn a clone at the player's position
        GameObject clone = Instantiate(clonePrefab, spawnPosition, Quaternion.identity);
        if (cloneParent != null)
        {
            clone.transform.parent = cloneParent;
        }

        Debug.Log("Clone spawned at: " + spawnPosition);
    }

    public void OnPlayerCaught()
    {
        Debug.Log("Game Over! The player was caught by a clone!");
        // Implement game over logic (e.g., reload scene or show UI)
    }
}
