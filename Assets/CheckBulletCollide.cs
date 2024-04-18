using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBulletCollide : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
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
        }
    }
}
