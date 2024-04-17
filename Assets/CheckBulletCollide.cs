using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBulletCollide : MonoBehaviour
{
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Check");

        if(other.gameObject.tag == "Bullet")
        {
            CameraTracker.camerasDestroyed++;
            Destroy(gameObject);
        }
    }
}
