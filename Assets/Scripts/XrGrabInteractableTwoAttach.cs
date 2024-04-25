using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XrGrabInteractableTwoAttach : XRGrabInteractable
{
    //override script used on the gun to gain two transform points based on which hand is being used
    //also contains holster for the positioning of the gun

    public Transform leftAttachTransform;
    public Transform rightAttachTransform;
    public Transform holster;

    public bool Attached;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        Attached = true;
        if (args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = rightAttachTransform;
        }
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = leftAttachTransform;
        }

        base.OnSelectEntered(args);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        Attached = false;

        base.OnSelectExited(args);
    }

    private void Update()
    {
        if(!Attached)
        {
            transform.position = holster.position;
            transform.rotation = holster.rotation;
        }
    }

}
