using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{
    //script to fire bullets from the gun game object

    [SerializeField] private AudioSource gunShot;
    public GameObject bullet;
    public Transform spawnPoint;
    public float FireSpeed = 20f;
    
    void Start()
    {
        //finds the xr grab interactable script and adds an event when the trigger is pressed to fire a bullet

        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(ShootBullet);

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet); 
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * FireSpeed;
        gunShot.Play();
        Destroy(spawnedBullet, 5);

        //spawns bullet, sets position and velocity, plays sounds, deletes object after 5 seconds.
    }


}
