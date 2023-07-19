using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private float sprintSpeed = 10f;
    private float normalSpeed = 5f;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = normalSpeed;
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // If yes, set the current speed to sprintSpeed
            speed = sprintSpeed;
        }
        else
        {
            // If not, set the current speed to normalSpeed
            speed = normalSpeed;
        }
    }
    //receive input for inputmanager and apply to character controler
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

    }
}
