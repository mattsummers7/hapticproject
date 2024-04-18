using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticConstant : MonoBehaviour
{
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
        leftController.SendHapticImpulse(1f, 1f);
        rightController.SendHapticImpulse(1f, 1f);
    }
}
