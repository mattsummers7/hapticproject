using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticConstant : MonoBehaviour
{
    //constant haptic feedback for the boat section to emulate boat engine.

    [SerializeField] private XRBaseController leftController;
    [SerializeField] private XRBaseController rightController;

    public static bool isOn = false;
    private void Update()
    {
        if(!EndGame.endFunction)
        {
            if (isOn)
            {
                ActivateHaptic();
            }
        }
        
    }

    public void ActivateHaptic()
    {
        //send impulses to controllers
        leftController.SendHapticImpulse(1f, 1f);
        rightController.SendHapticImpulse(1f, 1f);
    }
}
