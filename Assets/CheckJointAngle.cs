using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJointAngle : MonoBehaviour
{
    private void Update()
    {
        if(GetComponent<HingeJoint>().angle >= 120)
        {
            Debug.Log("True");
        }
    }
}
