using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;    // Speed for horizontal movement
    public float jumpForce = 10f;  // Force applied when jumping
    public LayerMask groundLayer;  // Layer for detecting ground

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        // Horizontal Movement
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // Check if the player is on the ground
        isGrounded = IsGrounded();

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    // Method to check if the player is on the ground using a raycast
    private bool IsGrounded()
    {
        Vector2 position = transform.position;
        float rayLength = 0.6f; // Adjust to fit the size of your player

        // Perform a raycast downward to check for ground
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.down, rayLength, groundLayer);

        // Debugging: Draw the ray in the Scene view
        Debug.DrawRay(position, Vector2.down * rayLength, Color.red);

        // Return true if the ray hits a collider in the ground layer
        return hit.collider != null;
    }
}
