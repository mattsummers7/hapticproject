using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class jumpBehaviour : MonoBehaviour
{
    [SerializeField] private InputActionProperty jumpButton;
    [SerializeField] private float jumpIntensity = 3f;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private XRBaseController leftController;
    [SerializeField] private XRBaseController rightController;

    private float gravity = Physics.gravity.y;
    private Vector3 movement;

    private void Update()
    {

            bool isGrounded = IsGrounded();


            if (jumpButton.action.WasPressedThisFrame() && isGrounded)
            {
                Jump();
                leftController.SendHapticImpulse(1f, .2f);
                rightController.SendHapticImpulse(1f, .2f);
            }

            movement.y += gravity * Time.deltaTime;

            characterController.Move(movement * Time.deltaTime);
        
        
    }

    private void Jump()
    {
        movement.y = Mathf.Sqrt(jumpIntensity * -3.0f * gravity);
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(transform.position, 0.2f, groundLayer);
    }
}
