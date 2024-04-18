using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private GameObject endScreen;
    void Update()
    {
        if(EndGame.endFunction)
        {
            endScreen.SetActive(true);
        }
    }
}
