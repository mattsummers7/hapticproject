using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldTracker : MonoBehaviour
{
    [SerializeField] private GameObject exitWall;

    public int goldCollected;

    void Update()
    {
        if(goldCollected == 4)
        {
            exitWall.SetActive(false);
        }
          
    }

    
}
