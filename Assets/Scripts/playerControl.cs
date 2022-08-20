
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class playerControl : MonoBehaviour
{
    [SerializeField]
    private InputActionReference movementControl;
    [SerializeField]
    private InputActionReference jumpControl;
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;


    private InputManager inputManager;//Calling Inputmanager class 

    private void Start()
    {
        controller = GetComponent<CharacterController>();//getting the playerController
        inputManager = InputManager.Instance;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;//Ground check
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
            // print ("grounded check");
        }

        Vector2 movement = inputManager.GetPlayerMovement();//getting the player movement from InputManager
        Vector3 move = new Vector3(movement.x, 0, movement.y);

        controller.Move(move * Time.deltaTime * playerSpeed);//moving the player



        // Changes the height position of the player..
        if (inputManager.JumpPerFrame() && groundedPlayer)
        {
            // print("Jump");
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);//Calculating the jump
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);//Doing The Jump
    }
}