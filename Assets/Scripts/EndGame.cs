using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    //script for after the boat has reached the end of the level

    public static bool endFunction;
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0; //stop logic in the update funciton
        TimerLogic.isPlaying = false; //timer stop
        OpenTimer.openTimer = true; //open timer on screen
        endFunction = true; //function to end certain events such as haptic vibration
    }
}
