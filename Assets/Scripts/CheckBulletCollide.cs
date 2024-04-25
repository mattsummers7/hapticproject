using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBulletCollide : MonoBehaviour
{
    //script on cameras that checks whether the a bullet fired from the gun as collided with the camera.
    //if true then it is destroyed and this is passed through to the camera tracker.

    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] AudioSource explosionAudioSource;
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
            Instantiate(explosionPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            explosionAudioSource.Play();
        }
    }
}
