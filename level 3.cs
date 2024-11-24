using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene transitions

public class BlockHitSceneChange : MonoBehaviour
{
    [Tooltip("The name of the scene to load when the block is hit.")]
    public string nextScene;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            ChangeScene();
        }
    }

    private void ChangeScene()
    {
        if (!string.IsNullOrEmpty(nextScene))
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            Debug.LogError("Next scene name is not set in the Inspector!");
        }
    }
}