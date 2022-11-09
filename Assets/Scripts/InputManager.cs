using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.StandardActions sA;
    private PlayerMotor motor;
    private PlayerCamera turnCam;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        sA = playerInput.Standard;
        motor = GetComponent<PlayerMotor>();
        turnCam = GetComponent<PlayerCamera>();
        sA.Jump.performed += ctx => motor.Jump();
    }

    void FixedUpdate()
    {
        // Telling the PlayerMotor script to call the MoveCharacter function using values from the Movement action (from the Input System)
        motor.MoveCharacter(sA.Movement.ReadValue<Vector2>());
    }

    void LateUpdate()
    {
        turnCam.MoveCamera(sA.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        sA.Enable();
    }
    
    private void OnDisable()
    {
        sA.Disable();
    }
}
