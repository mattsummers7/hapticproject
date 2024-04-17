using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJointAngle : MonoBehaviour
{
    [SerializeField] GameObject boat;
    private void FixedUpdate()
    {
        if(GetComponent<HingeJoint>().angle >= 90)
        {
            boat.transform.position = new Vector3(boat.transform.position.x - .1f, boat.transform.position.y, boat.transform.position.z);
            
        }
    }
}
