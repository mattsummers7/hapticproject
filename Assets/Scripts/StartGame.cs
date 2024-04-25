using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    //script for starting the game
    //similar to respawnPlayer it deletes the player in the world and makes a new one at the correct position.

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject prefabplayer;

    

    public void BeginGame()
    {
        ChangeObjectiveText.shootCameras = true;
        Destroy(player);
        GameObject newPlayer = Instantiate(prefabplayer);
        newPlayer.transform.position = spawnPoint.position;
        newPlayer.transform.rotation = spawnPoint.rotation;
        TimerLogic.isPlaying = true;
        
    }
}
