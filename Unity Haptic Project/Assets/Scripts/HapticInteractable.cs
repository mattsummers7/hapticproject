using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    [Range(0f, 1f)]
    public float intensity;
    public float duration;

    private void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.selectEntered.AddListener(TriggerHaptic);
        interactable.activated.AddListener(TriggerHaptic);
    }

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {

        if(eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
       if(intensity > 0)
        {
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}
