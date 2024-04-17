using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateJump : MonoBehaviour
{
    [SerializeField] private jumpBehaviour jump;
    [SerializeField] private GameObject respawnBox;

    private void OnTriggerEnter(Collider other)
    {
        if (jump != null)
        {
            jump.enabled = true;
            respawnBox.SetActive(true);
        }

        
    }
}
