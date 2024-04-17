using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class respawnPlayer : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            Destroy(other.gameObject);
            GameObject newPlayer = Instantiate(player);
            newPlayer.transform.position = respawnPoint.position;
            newPlayer.transform.rotation = respawnPoint.rotation;
        }
    }
}
