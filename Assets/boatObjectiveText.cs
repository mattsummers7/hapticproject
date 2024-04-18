using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatObjectiveText : MonoBehaviour
{
    public ChangeObjectiveText text;
    private void OnTriggerEnter(Collider other)
    {
            ChangeObjectiveText.escapeRoofJump = false;
            ChangeObjectiveText.escapeBoat = true;
            gameObject.SetActive(false);
    }
}

