using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    [SerializeField] private BoxCollider2D triggerCollider;
    [SerializeField] private BoxCollider2D platformCollider;


    private void Start()
    {
        platformCollider = GetComponentInChildren<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            // Disable collision if the player is below the platform
            if (collider.transform.position.y < transform.position.y)
            {
                platformCollider.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            // Re-enable collision when the player exits the trigger
            platformCollider.enabled = true;
        }
    }
}
