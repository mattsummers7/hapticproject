using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class startBoat : MonoBehaviour
{
    //script that start the boat segment - instead of moving the boat the entire world moves backwards rather than the boat
    //this solves problems with parenting the the boat randomly flinging off the player

    [SerializeField] private GameObject world;

    bool hasPressed = false;

    void FixedUpdate()
    {
        if(hasPressed)
        {
            world.transform.position = new Vector3(world.transform.position.x - .1f, world.transform.position.y, world.transform.position.z);
            HapticConstant.isOn = true;
        }
    }

    public void PressButton()
    {
        hasPressed = true;
    }
}
