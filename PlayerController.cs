using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Basic movement logic
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
/*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            // Notify GameManager about apple collection
            GameManager.Instance.OnAppleCollected(transform.position);
            Destroy(collision.gameObject); // Destroy the apple
        }
        else if (collision.CompareTag("Clone"))
        {
            // Notify GameManager about the player's death
            GameManager.Instance.OnPlayerCaught();
        }
    }*/
}
