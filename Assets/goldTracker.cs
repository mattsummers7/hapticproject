using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldTracker : MonoBehaviour
{
    [SerializeField] private GameObject exitWall;

    public int goldCollected;

    void Update()
    {
        if(goldCollected == 4)
        {
            StartCoroutine(switchOff());
        }
          
    }

    public IEnumerator switchOff()
    {
        exitWall.SetActive(false);
        ChangeObjectiveText.findGold = false;
        ChangeObjectiveText.escapeWallClimb = true;
        yield return new WaitForSeconds(1);
        ChangeObjectiveText.escapeWallClimb = false;
        goldCollected = 0;
    }


}
