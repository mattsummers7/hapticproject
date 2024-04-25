using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateJump : MonoBehaviour
{
    //Jumping logic didn't interact well with the climbing so this script along with deactivate jump turns the script on and off.

    [SerializeField] private jumpBehaviour jump;
    [SerializeField] private GameObject respawnBox;

    public bool isTutorial;

    private void OnTriggerEnter(Collider other)
    {
        if (jump != null)
        {
            jumpBehaviour.canJump = true; //static bool for engabling jump logic
            respawnBox.SetActive(true);
            if(!isTutorial)
            {
                StartCoroutine(changeText()); //UI text letting the player know of the next objective
            }
            
        }

        
    }

    public IEnumerator changeText()
    {
        ChangeObjectiveText.escapeWallClimb = false;
        ChangeObjectiveText.escapeRoofJump = true;
        yield return new WaitForSeconds(1f);
        ChangeObjectiveText.escapeRoofJump = false;
    }
}
