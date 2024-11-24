using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object is on the Hazard layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            SceneManager.LoadScene("end");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Alternative: Check for trigger collisions with Hazard layer
        if (other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            SceneManager.LoadScene("end");
        }
    }
}
