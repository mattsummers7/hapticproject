using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    //script to track the number of cameras in the scene to make sure they have all been destroyed

    public static int camerasDestroyed; //static bool so it can be accessed across the project.

    private void LateUpdate()
    {
        if (camerasDestroyed == 3)
        {
            StartCoroutine(switchOff());
        }
    }

    public IEnumerator switchOff()
    {
        ChangeObjectiveText.shootCameras = false;
        ChangeObjectiveText.findGold = true;
        yield return new WaitForSeconds(1);
        ChangeObjectiveText.findGold = false;
        camerasDestroyed = 0; //turns cameras destroyed to 0 otherwise screen objective text would flicker on screen.
    }
}
