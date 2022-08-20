using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;//globalizing for cross scrpit use

    public static InputManager Instance{
        get {
            return _instance;
        }
    }
    private TpsPlayerController playerControls;


    private void Awake()
    {
        if (_instance != null && _instance != this)//Handling if instance is null or multiple copies present 
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        playerControls = new TpsPlayerController();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()//Taking the player input for movement
    {
        return playerControls.Player.Movement.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()//Taking the player input for mouse look
    {
        return playerControls.Player.MouseLook.ReadValue<Vector2>();
    }

    public bool JumpPerFrame()//Taking the player input for jump
    {
        return playerControls.Player.Jump.triggered;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
