using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private AudioSource gunShot;
    public GameObject bullet;
    public Transform spawnPoint;
    public float FireSpeed = 20f;
    
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullett);

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullett(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * FireSpeed;
        gunShot.Play();
        Debug.Log("PEWPEWPEW");
        Destroy(spawnedBullet, 5);
    }


}
