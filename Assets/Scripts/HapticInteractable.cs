using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    //script for the haptic feedback in for gameobjects in the scene

    //variables
    [Range(0f, 1f)]
    public float intensity;
    public float duration;

    private void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.selectEntered.AddListener(TriggerHaptic); //trigger on select pressed
        interactable.activated.AddListener(TriggerHaptic); //trigger on trigger press
    }

    //finds out which controller is being used to send the haptic feedback to the right devcice on event start
    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {

        if(eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    //applies haptic feedback to the correct device
    public void TriggerHaptic(XRBaseController controller)
    {
       if(intensity > 0)
        {
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}
