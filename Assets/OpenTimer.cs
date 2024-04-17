using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenTimer : MonoBehaviour
{
    [SerializeField] private InputActionProperty menuButton;
    [SerializeField] private GameObject timerUI;

    private bool openTimer;

    private void Update()
    {
        
        if(menuButton.action.WasPerformedThisFrame())
        {
            openTimer = !openTimer;
        }

        timerUI.SetActive(openTimer);
    }
}
