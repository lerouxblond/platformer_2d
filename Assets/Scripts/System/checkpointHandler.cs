using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class checkpointHandler : MonoBehaviour
{

    [Header("startPoint")]
    [SerializeField] private startPointSpawn spawnPoint;

    [Header("Settings")]
    [SerializeField] private bool activated = false;
    [SerializeField] protected SpriteRenderer sprite;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player") && !activated)
        {
            activated = true;
            sprite.color = Color.green;
            spawnPoint.startPosition = transform.position;
        }
    }
}
