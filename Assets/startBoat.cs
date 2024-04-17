using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class startBoat : MonoBehaviour
{
    [SerializeField] private GameObject boat;

    bool hasPressed = false;

    void FixedUpdate()
    {
        if(hasPressed)
        {
            boat.transform.position = new Vector3(boat.transform.position.x - .1f, boat.transform.position.y, boat.transform.position.z);
            HapticConstant.isOn = true;
        }
    }

    public void PressButton()
    {
        hasPressed = true;
    }
}
