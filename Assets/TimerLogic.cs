using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour
{
    
    public static float timer;
    public static bool isPlaying;

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        if (isPlaying)
        {
            timer += Time.deltaTime;
        }
        
    }


}
