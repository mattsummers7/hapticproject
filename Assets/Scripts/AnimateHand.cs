using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    //hand grabbing and pinching animation using input system values

    public InputActionProperty pinchAnimationInput;
    public InputActionProperty gripAnimationInput;

    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationInput.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationInput.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
