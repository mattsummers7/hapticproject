using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateJump : MonoBehaviour
{
    [SerializeField] private jumpBehaviour jump;
    [SerializeField] private GameObject respawnBox;

    private void OnTriggerEnter(Collider other)
    {
        if (jump != null)
        {
            jump.enabled = false;
            respawnBox.SetActive(false);
        }


    }
}
