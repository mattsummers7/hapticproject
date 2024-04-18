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
            jumpBehaviour.canJump = false;
            respawnBox.SetActive(false);
        }


    }
}
