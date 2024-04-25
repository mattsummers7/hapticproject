using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    //end screen script - a black background with text saying well done.

    [SerializeField] private GameObject endScreen;
    void Update()
    {
        if(EndGame.endFunction)
        {
            endScreen.SetActive(true);
        }
    }
}
