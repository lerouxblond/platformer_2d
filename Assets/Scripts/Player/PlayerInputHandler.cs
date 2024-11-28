using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputHandler : MonoBehaviour
{

    [Header("Input Instance")]
    public static PlayerInputHandler Instance {get; private set;}

    [Header("Input Values")]
    public Vector2 MoveInput {get; private set;}
    public Vector2 CameraInput {get; private set;}
    public bool JumpTriggered {get; private set;}

    [Header("Action Map")]
    [SerializeField] private Player_Input_System _playerControls;

    [Header("Debugging")]
    [SerializeField] private Vector2 debugMoveInput;
    [SerializeField] private Vector2 debugCameraInput;
    [SerializeField] private bool debugJumpTriggered;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        _playerControls = new Player_Input_System();
    }

    private void OnEnable()
    {
        _playerControls.Enable();

        _playerControls.Player.Camera.performed += OnCameraPerformed;
        _playerControls.Player.Camera.canceled += OnCameraCanceled;
        _playerControls.Player.Move.performed += OnMovePerformed;
        _playerControls.Player.Move.canceled += OnMoveCanceled;
        _playerControls.Player.Jump.performed += OnJumpPerformed;
        _playerControls.Player.Jump.canceled += OnJumpCanceled;
    }


    private void OnDisable()
    {
        _playerControls.Disable();

        _playerControls.Player.Camera.performed -= OnCameraPerformed;
        _playerControls.Player.Camera.canceled -= OnCameraCanceled;
        _playerControls.Player.Move.performed -= OnMovePerformed;
        _playerControls.Player.Move.canceled -= OnMoveCanceled;
        _playerControls.Player.Jump.performed -= OnJumpPerformed;
        _playerControls.Player.Jump.canceled -= OnJumpCanceled;
    }

    private void OnCameraCanceled(InputAction.CallbackContext context)
    {
        CameraInput = Vector2.zero;
        debugCameraInput = CameraInput;
    }

    private void OnCameraPerformed(InputAction.CallbackContext context)
    {
        CameraInput = context.ReadValue<Vector2>();

        if (CameraInput.magnitude > 1)
        {
            CameraInput = CameraInput.normalized;
        }
        debugCameraInput = CameraInput;
    }

    private void OnJumpCanceled(InputAction.CallbackContext context)
    {
        JumpTriggered = false;
        debugJumpTriggered = JumpTriggered;
    }

    private void OnJumpPerformed(InputAction.CallbackContext context)
    {
        JumpTriggered = true;
        debugJumpTriggered = JumpTriggered;
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        MoveInput = Vector2.zero;

        debugMoveInput = MoveInput;
        print(debugMoveInput);
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();

        if (MoveInput.magnitude > 1)
        {
            MoveInput = MoveInput.normalized;
        }

        debugMoveInput = MoveInput;
        print(debugMoveInput);
    }
}
