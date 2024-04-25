using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class respawnPlayer : MonoBehaviour
{
    //script used for when the player falls off the roof during the jumping segment

    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //problems with moving the player directly led to the solution of deleting the player character and respawning them in the right location.
            Destroy(other.gameObject);
            GameObject newPlayer = Instantiate(player);
            newPlayer.transform.position = respawnPoint.position;
            newPlayer.transform.rotation = respawnPoint.rotation;
        }
    }
}
