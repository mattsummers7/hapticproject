using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateJump : MonoBehaviour
{
    //Jumping logic didn't interact well with the climbing so this script along with activate jump turns the script on and off.

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
