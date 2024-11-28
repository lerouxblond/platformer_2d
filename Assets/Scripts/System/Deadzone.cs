using UnityEngine;


public class Deadzone : MonoBehaviour
{
    [SerializeField] private startPointSpawn spawn;
    [SerializeField] private Transform player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            player.position = spawn.startPosition;
        }
    }
}
