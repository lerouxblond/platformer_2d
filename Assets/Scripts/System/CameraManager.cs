using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [Header("Target")]
    [SerializeField] private Transform target;

    [Header("Camera Movement Limits")]
    [SerializeField] private Vector2 minLimits;
    [SerializeField] private Vector2 maxLimits;

    [Header("Camera Settings")]
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset;

    [Header("Player Input")]
    private Vector2 moveInput;
    [SerializeField] float cameraSpeed = 2.5f;

    private Vector3 velocity = Vector3.zero;

    public CameraManager Instance {get; private set;}

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void LateUpdate()
    {
        if(target == null)
        {
            Debug.LogWarning("Target is not assigned!");
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 inputCamera = PlayerInputHandler.Instance.CameraInput;

        desiredPosition.x = Mathf.Clamp(desiredPosition.x, minLimits.x, maxLimits.x);
        desiredPosition.y = Mathf.Clamp(desiredPosition.y, minLimits.y, maxLimits.y);

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        Vector3 smoothedInputPosition = Vector3.SmoothDamp(transform.position,desiredPosition + (inputCamera * cameraSpeed), ref velocity, smoothSpeed);
        transform.position = smoothedInputPosition;
    }


}
