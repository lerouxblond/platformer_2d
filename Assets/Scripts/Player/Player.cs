using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player settings")]
    [SerializeField] protected float moveSpeed = 5f;
    [SerializeField] protected float jumpForce = 2f;

    [Header("Player Component")]
    protected Rigidbody2D rb;
    protected bool isGrounded;

    [Header("Player Input")]
    public PlayerInputHandler playerInput;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    protected bool checkGrounded()
    {
        
    float rayLength = 0.1f; 
    Vector2 rayOrigin = new Vector2(transform.position.x, transform.position.y - 0.5f); // Adjust Y based on collider size
    LayerMask groundLayer = LayerMask.GetMask("Ground");

    RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.down, rayLength, groundLayer);


    Debug.DrawRay(rayOrigin, Vector2.down * rayLength, hit.collider ? Color.green : Color.red);

    return hit.collider != null;
    }
}
