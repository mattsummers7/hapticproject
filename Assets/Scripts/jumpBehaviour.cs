using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class jumpBehaviour : MonoBehaviour
{
    //jump logic for player 

    [SerializeField] private InputActionProperty jumpButton;
    [SerializeField] private float jumpIntensity = 3f;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private AudioSource jumpSound;

    [SerializeField] private XRBaseController leftController;
    [SerializeField] private XRBaseController rightController;

    private float gravity = Physics.gravity.y;
    private Vector3 movement;

    public static bool canJump;

    private void Update()
    {
        if(canJump)
        {
            bool isGrounded = IsGrounded();


            if (jumpButton.action.WasPressedThisFrame() && isGrounded)
            {
                Jump();
                jumpSound.Play();
                leftController.SendHapticImpulse(1f, .2f); //haptic feedback for jumping
                rightController.SendHapticImpulse(1f, .2f);
            }

            movement.y += gravity * Time.deltaTime; //constant gravity on player

            characterController.Move(movement * Time.deltaTime);
        }
            
        
        
    }

    private void Jump()
    {
        movement.y = Mathf.Sqrt(jumpIntensity * -3.0f * gravity); 
        //jump logic
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(transform.position, 0.2f, groundLayer);
        //physics raycast to check if the player is on the ground
    }
}
