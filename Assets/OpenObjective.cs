using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenObjective : MonoBehaviour
{
    [SerializeField] private InputActionProperty menuButton;
    [SerializeField] private GameObject objectiveUI;

    private bool openObjective;

    private void Update()
    {

        if (menuButton.action.WasPerformedThisFrame())
        {
            openObjective = !openObjective;
            Debug.Log("check67");

        }

        objectiveUI.SetActive(openObjective);
    }
}
