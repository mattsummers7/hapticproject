using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenTimer : MonoBehaviour
{
    //logic to open timer if the player wants to see their current time

    [SerializeField] private InputActionProperty menuButton;
    [SerializeField] private GameObject timerUI;

    public static bool openTimer;

    private void Update()
    {
        
        if(menuButton.action.WasPerformedThisFrame())
        {
            openTimer = !openTimer;
        }

        timerUI.SetActive(openTimer);
    }
}
