using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class updateTimer : MonoBehaviour
{
    [SerializeField] private Text timerText;

    private void Update()
    {
        timerText.text = TimerLogic.timer.ToString("f2");
    }
}
