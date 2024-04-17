using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    public static int camerasDestroyed;

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
        camerasDestroyed = 0;
    }
}
