using UnityEngine;

public class Clone : MonoBehaviour
{
    public float chaseSpeed = 3f;
    private Transform player;

    private void Start()
    {
        // Locate the player
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player != null)
        {
            // Move towards the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);
        }
    }
}
