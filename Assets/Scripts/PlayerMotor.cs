using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    [SerializeField]
    private float speed = 5f;
    private float gravity = -9.81f;
    [SerializeField]
    private float jumpHeight = 2.5f;
    private bool grounded;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = controller.isGrounded;
    }

    // Recieve the inputs from InputManager.cs and apply them to the player object's Character Controller.
    public void MoveCharacter(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime * 2;
        if(grounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }
        controller.Move(velocity * Time.deltaTime);
    }
    

    public void Jump()
    {
        if(grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -1f * gravity);
        }
    }
}
