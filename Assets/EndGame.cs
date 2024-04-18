using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public static bool endFunction;
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        TimerLogic.isPlaying = false;
        OpenTimer.openTimer = true; ;
        endFunction = true;
    }
}
