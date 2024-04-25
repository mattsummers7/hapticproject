using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SafeWin : MonoBehaviour
{
    //script to check the numbers on the safe puzzle and enabled the player to open the glass if they are correct

    [SerializeField] private CheckNumber button1;
    [SerializeField] private CheckNumber button2;
    [SerializeField] private CheckNumber button3;
    void Update()
    {
        if(button1.correct &&  button2.correct && button3.correct)
        {
            GetComponent<XRGrabInteractable>().enabled = true;
        }
        
    }
}
