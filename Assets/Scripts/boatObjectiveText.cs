using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatObjectiveText : MonoBehaviour
{
    //UI text change for objective

    public ChangeObjectiveText text;
    private void OnTriggerEnter(Collider other)
    {
            ChangeObjectiveText.escapeRoofJump = false;
            ChangeObjectiveText.escapeBoat = true;
            gameObject.SetActive(false);
    }
}

