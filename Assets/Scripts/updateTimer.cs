using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class updateTimer : MonoBehaviour
{
    //script for updating the timer

    [SerializeField] private Text timerText;

    private void Update()
    {
        timerText.text = TimerLogic.timer.ToString("f2");
    }
}
